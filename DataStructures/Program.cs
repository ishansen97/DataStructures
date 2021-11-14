using DataStructures.Queue;
using DataStructures.Stack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        private static string path = "log.txt";

        static void Main(string[] args)
        {
            /*StackMethod();
            SomeMethod1();*/
            //QueueMethod();
        }

        private static void QueueMethod()
        {
            var item1 = new QueueItem { Name = "Ishan", Age = 22 };
            var item2 = new QueueItem { Name = "Janadi", Age = 18 };
            var item3 = new QueueItem { Name = "Pika", Age = 25 };
            var item4 = new QueueItem { Name = "Roshni", Age = 19 };
            var item5 = new QueueItem { Name = "Jahrin", Age = 30 };

            var queue = new RegularQueue();

            // enqueue
            queue.Enqueue(item1);
            queue.Enqueue(item2);
            queue.Enqueue(item3);
            queue.Enqueue(item4);
            queue.Enqueue(item5);

            Console.WriteLine("bla");

            // remove
            queue.Dequeue();

            Console.WriteLine($"Now i am at the front: {queue.Peek().Name}");
            queue.Enqueue(new QueueItem { Name = "Harry Styles", Age = 27});
        }

        private static void StackMethod()
        {
            // create items
            var item1 = new Item { Name = "Ishan", Value = 100 };
            var item2 = new Item { Name = "Erandi", Value = 101 };
            var item3 = new Item { Name = "Pika", Value = 102 };
            var item4 = new Item { Name = "James", Value = 103 };
            var item5 = new Item { Name = "Andrew", Value = 104 };
            // create the stack
            var stack = new StackTest();

            // push items
            stack.Push(item1);
            stack.Push(item2);
            stack.Push(item3);
            stack.Push(item4);
            stack.Push(item5);

            SomeMethod2();

            var message1 = $"{DateTime.Now.ToLocalTime()}\t Top item: {stack.Peek().Name}";

            // peek and see :O
            FileWriter(message1);

            // remove top
            var topItem = stack.Pop();
            var message2 = $"{DateTime.Now.ToLocalTime()}\t Removed Item: {topItem.Name}";
            var message3 = $"{DateTime.Now.ToLocalTime()}\t Top after removing: {stack.Peek().Name}";

            FileWriter(message2);
            FileWriter(message3);
        }

        private static void SomeMethod1() => Console.WriteLine("method 1");

        private static void SomeMethod2() => Console.WriteLine("inside method");

        private static void FileWriter(string message)
        {
            using (var log = File.AppendText(path))
            {
                log.WriteLine(message);
                log.Flush();
            }
        }
    }
}
