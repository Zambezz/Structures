using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ConsoleNumberGuesser
{
    class Program
    {

        static void Main(string[] args)
        {
           
            string[] array = new string[10000]; 
            for (int i = 0; i < 10000; i++)
            {
                array.SetValue("Tom" + i, i);
            };

            LinkedList<string> linkedlist = new LinkedList<string>(array);
            Queue<string> queue = new Queue<string>(array);

            Array(array);
            LinkedList(linkedlist);
            Queue(queue);

            Console.ReadLine();
        }

        static void Array(string[] array)
        {
            Console.WriteLine("ARRAY");
            ConsoleColor c = ConsoleColor.Yellow;
            int a = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var i in array)
            {
                a = (a++) / 2 * i.Length;
            };
            watch.Stop();
            G($"ForEach: {watch.Elapsed}");
        }

        static void Queue(Queue<string> queue)
        {
            Console.WriteLine("QUEUE");
            ConsoleColor c = ConsoleColor.Yellow;
            int a = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var i in queue)
            {
                a = (a++) / 2 * i.Length;
            };
            watch.Stop();
            G($"ForEach: {watch.Elapsed}");

            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("Kate");
            queue1.Enqueue("Sam");
            queue1.Enqueue("Alice");
            queue1.Enqueue("Tom");
            queue1.Dequeue(); 
        }



        static void LinkedList(LinkedList<string> linkedlist)
        {
            Console.WriteLine("LINKEDLIST");
            int a = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var i in linkedlist)
            {

                a = (a++) / 2 * i.Length;
            };
            watch.Stop();
            G($"ForEach: {watch.Elapsed}");
        }

        public static void G(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Execution Time: {text} ms");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
