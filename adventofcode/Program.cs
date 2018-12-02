using System;
using System.IO;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First day------");
            Console.WriteLine(Days.One.FirstChallenge());
            Console.WriteLine("---------------");
            Console.WriteLine(Days.One.SecondChallenge());
            Console.WriteLine("Second day------");
            Console.WriteLine(Days.Two.FirstChallenge());
            Console.WriteLine("---------------");
            Console.WriteLine(Days.Two.SecondChallenge());
            Console.ReadKey(true);
        }
    }
}
