using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueePracticeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> aQueue = new Queue<int>();
            Stack<int> aQueue = new Stack<int>();

            aQueue.Push(100);
            aQueue.Push(300);
            aQueue.Push(430);

            Console.WriteLine(aQueue.Pop());
            Console.WriteLine(aQueue.Pop());
            Console.WriteLine(aQueue.Pop());

            foreach (int anItem in aQueue)
            {
                Console.WriteLine(anItem);
            }

            //aQueue.Enqueue(100);
            //aQueue.Enqueue(300);
            //aQueue.Enqueue(430);

            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());

            Console.ReadKey();


        }
    }
}
