using DataStructures.Stack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            StackMethod();
            SomeMethod1();
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

            // peek and see :O
            Console.WriteLine($"Top item: {stack.Peek().Name}");

            // remove top
            var topItem = stack.Pop();
            Console.WriteLine($"Removed Item: {topItem.Name}");
            Console.WriteLine($"Top after removing: {stack.Peek().Name}");
        }

        private static void SomeMethod1() => Console.WriteLine("method 1");

        private static void SomeMethod2() => Console.WriteLine("inside method");
    }
}
