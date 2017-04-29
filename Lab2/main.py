import sys
from random import randint
from time import sleep
from operator import itemgetter
from multiprocessing import Process, Pipe, Lock

KO_ITERATIONS = 5
KO_REPEATS = randint(2, 5)
print 'KO will be executed ' + str(KO_REPEATS) + ' times'
REQUEST = 'request'
RESPONSE = 'response'
FINISHED = 'finished'

def lamport(id, input_pipes, output_pipes, lock):
    local_time = randint(0, 30)
    queue = list()
    response_counter = 0

    for i in range(KO_REPEATS):
        my_request = [id, local_time, False, False]
        queue.append(my_request)
        send_message(id, output_pipes, REQUEST + ' ' + str(id) + ' ' + str(local_time))

        while True:
            #new_queue = queue
            for request in queue:
                if request[0] != id and request[2] and not request[3]:
                    messages = receive_individual(id, queue[0][0], input_pipes)
                    request[3] = True
                    queue = queue[1:]

            messages = receive_messages(id, input_pipes, queue)
            new_requests, local_time, responses, finish = parse_messages(messages, local_time)

            response_counter += responses

            if finish:
                queue = queue[1:]

            for item in new_requests:
                queue.append(item)
            queue = sorted(queue, key=itemgetter(1))

            for request in queue:
                if request[0] != id and not request[2]:
                    send_individual_message(id, output_pipes, request, local_time)
                    request[2] = True

            messages = receive_messages(id, input_pipes, queue)
            new_requests, local_time, responses, finish = parse_messages(messages, local_time)

            response_counter += responses

            if finish:
                queue = queue[1:]

            for item in new_requests:
                queue.append(item)
            queue = sorted(queue, key=itemgetter(1))

            while queue[0][0] != id:
                messages = receive_individual(id, queue[0][0], input_pipes)
                queue = queue[1:]

            if response_counter == len(input_pipes[id]) - 1 and queue[0][0] == id:
                response_counter = 0

                lock.acquire()

                for i in range(KO_ITERATIONS):
                    print 'Process ' + str(id) + ' is in KO - iteration ' + str(i)
                    sleep(1)

                lock.release()

                send_message(id, output_pipes, FINISHED + ' ' + str(id) + ' ' + str(queue[0][1]))
                queue = queue[1:]
                break

def receive_individual(id, sender_id, input_pipes):
    messages = list()

    message = input_pipes[id][sender_id].recv()
    print 'Process ' + str(id) + ' received message ' + message
    messages.append(message)

    return messages

def parse_messages(messages, local_time):
    requests = list()
    new_local_time = local_time
    responses = 0
    finish = False

    for message in messages:
        split = message.split()
        request_local_time = int(split[2])
        new_local_time = max(new_local_time, request_local_time) + 1

        if split[0] == REQUEST:
            requests.append([int(split[1]), request_local_time, False, False])
        elif split[0] == RESPONSE:
            responses += 1
        else:
            finish = True

    return requests, new_local_time, responses, finish


def receive_messages(id, input_pipes, queue):
    messages = list()

    for pipe in input_pipes[id]:
        if pipe is not None:
            message = pipe.recv()
            print 'Process ' + str(id) + ' received message ' + message
            messages.append(message)

    return messages

def send_individual_message(id, output_pipes, request, local_time):
    pipe = output_pipes[request[0]][id]
    message = RESPONSE + ' ' + str(request[0]) +  ' ' + str(local_time)
    print 'Process ' + str(id) + ' sends message ' + message + ' to process ' + str(request[0])
    pipe.send(message)

def send_message(id, output_pipes, message):
    for key in output_pipes:
        pipe = output_pipes[key][id]
        if pipe is not None:
            print 'Process ' + str(id) + ' sends message ' + message + ' to process ' + str(key)
            pipe.send(message)

if len(sys.argv) != 2:
    print 'Invalid number of arguments passed to program!'
    sys.exit(1)

number_of_processes = int(sys.argv[1])
processes = list()
lock = Lock()

input_pipes = dict()
output_pipes = dict()

for i in range(number_of_processes):
    input_pipes[i] = [None] * number_of_processes
    output_pipes[i] = [None] * number_of_processes

for i in range(number_of_processes):
    for j in range(number_of_processes):
        if i != j:
            input_pipe, output_pipe = Pipe(False)
            input_pipes[i][j] = input_pipe
            output_pipes[i][j] = output_pipe

for i in range(number_of_processes):
    p = Process(target=lamport, args=(i, input_pipes, output_pipes, lock))
    processes.append(p)
    p.start()

for process in processes:
    process.join()