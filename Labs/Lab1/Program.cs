using System;
using System.Messaging;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    {
        private const string QueuePath = @".\private$\MyQueue";
        private const char Delimiter = '$';

        private static MessageQueue _messageQueue;
        private static Field _field;

        private static bool _first;
        private static string _playerName;
        private static string _playerDelimiter;

        public static void Main(string[] args)
        {
            if (args.Length > 1 && args[1] == "-clean")
            {
                MessageQueue.Delete(QueuePath);
            }

            _playerName = args[0];
            _playerDelimiter = Delimiter + _playerName;

            CreateMessageQueue();
            Initialize();
        }

        #region Utility methods

        private static void DeleteMessageQueue()
        {
            if (MessageQueue.Exists(QueuePath))
            {
                _messageQueue.Purge();
                _messageQueue.Close();
                _messageQueue.Dispose();
                MessageQueue.Delete(QueuePath);
            }
        }

        private static void CreateMessageQueue()
        {
            if (MessageQueue.Exists(QueuePath))
            {
                _messageQueue = new MessageQueue(QueuePath);
                Console.WriteLine("Queue exists");
            }
            else
            {
                _messageQueue = MessageQueue.Create(QueuePath);
                _messageQueue.Purge();
                Console.WriteLine("Queue created");
            }

            _messageQueue.Formatter = new XmlMessageFormatter(new[] {"System.String"});
        }

        private static void Initialize()
        {
            if (_messageQueue.GetAllMessages().Length == 0)
            {
                _first = true;
                SendReadyMessage();

                Console.WriteLine(ReceiveMessage());
                _field = new Field();

                AttackOpponent();
            }
            else
            {
                var message = ReceiveMessage();
                Console.WriteLine(message);

                if (message == Response.Ready)
                {
                    SendReadyMessage();
                }

                Thread.Sleep(500);

                _field = new Field();

                ReceiveOpponentAttackMessage();
            }
        }

        #endregion

        #region Attack Proccesing

        private static void AttackOpponent()
        {
            Console.WriteLine(_playerName + "\'s turn to attack ");

            var validInput = false;
            var input = "";

            while (!validInput)
            {
                try
                {
                    Console.Write("Attack field: ");
                    input = Console.ReadLine().Trim();
                    validInput = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You have entered a non integer value");
                }
                catch (IndexOutOfRangeException e2)
                {
                    Console.WriteLine("Entered range is not valid for this field");
                } 
            }

            SendAttackMessage(input);

            var message = ReceiveMessage();
            Console.WriteLine(message + Environment.NewLine);

            if (message == Response.Win)
            {
                Console.WriteLine("Press any key to quit");
                Console.ReadKey();
                return;
            }

            ReceiveOpponentAttackMessage();
        }

        private static void ReceiveOpponentAttackMessage()
        {
            Console.WriteLine("Opponent attacks");
            var message = ReceiveMessage();

            var outcome = _field.DetermineAttackOutcome(message);

            if (outcome == Response.Win)
            {
                SendWinMessage();
            }
            else
            {
                SendMessage(outcome);
                AttackOpponent();
            }
        }

        #endregion

        #region Send Messages

        private static void SendMessage(string text)
        {
            var message = new Message(text + _playerDelimiter);
            _messageQueue.Send(message);
        }

        private static void SendAttackMessage(string text)
        {
            SendMessage(text);
        }

        private static void SendReadyMessage()
        {
            SendMessage(Response.Ready);
        }

        private static void SendWinMessage()
        {
            SendMessage(Response.Win);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

            DeleteMessageQueue();
        }

        #endregion

        #region Receive Messages

        private static string ReceiveMessage()
        {
            while (!MessageArrived()) ;

            var message = _messageQueue.Receive();

            return ProcessMessage(message);
        }

        private static string ProcessMessage(Message message)
        {
            var body = message.Body.ToString();
            var split = body.Split(Delimiter);

            return split[0];
        }

        private static bool MessageArrived()
        {
            var message = _messageQueue.Peek();
            var split = message.Body.ToString().Split(Delimiter);

            return split[1] != _playerName;
        }

        #endregion
    }
}