using System;

namespace Lab1
{
    public class Field
    {
        public const byte BoardSize = 4;
        public const byte Ships = 6;
        private readonly bool[,] _field = new bool[BoardSize, BoardSize];

        private int _aliveShips;

        public Field()
        {
            var random = new Random();

            while (_aliveShips < 6)
            {
                var row = random.Next(0, BoardSize);
                var column = random.Next(0, BoardSize);

                if (!_field[row, column])
                {
                    _field[row, column] = true;
                    _aliveShips++;
                }
            }

            PrintField();
        }

        public void PrintField()
        {
            for (var i = 0; i < BoardSize; i++)
            {
                for (var j = 0; j < BoardSize; j++)
                {
                    Console.Write(_field[i, j] ? "O " : "- ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public string DetermineAttackOutcome(string input)
        {
            Console.WriteLine("Opponent fired at field: " + input);

            var split = input.Split(' ', '\t');
            var row = int.Parse(split[0]);
            var column = int.Parse(split[1]);

            if (_field[row, column])
            {
                _field[row, column] = false;
                _aliveShips--;

                if (_aliveShips == 0)
                {
                    Console.WriteLine("You lost!" + Environment.NewLine);
                    return Response.Win;
                }

                Console.WriteLine("Opponent hit");
                PrintField();
                return Response.Hit;
            }

            Console.WriteLine("Opponent miss" + Environment.NewLine);
            return Response.Miss;
        }
    }

    public sealed class Response
    {
        public const string Hit = "Hit";
        public const string Miss = "Miss";
        public const string Win = "You won!";
        public const string Ready = "Ready";
    }
}