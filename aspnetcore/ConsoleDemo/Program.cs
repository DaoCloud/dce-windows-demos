using System;
using System.Threading;


namespace ConsoleDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                PrintMsg();
                Thread.Sleep(500);
            }
        }

        private static void PrintMsg()
        {
            Console.WriteLine("hello the world!,the current time is " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));
        }
    }
}
