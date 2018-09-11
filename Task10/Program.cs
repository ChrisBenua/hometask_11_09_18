using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string separator = "! ";
            for (int i = 0; i < 3; ++i) {
                Console.Write(Console.ReadLine() + separator[i == 3 ? 1 : 0]);
            }
        }
    }
}
