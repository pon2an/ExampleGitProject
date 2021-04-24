using System;

namespace ข้อ._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input char : ");
            char CHAR = char.Parse(Console.ReadLine());
            Console.Write("input number (Step width) : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input number (Step height) : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("input number (Number of steps) : ");
            int c = int.Parse(Console.ReadLine());


            for (int x = 1; x <= c; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    for (int z = 1; z <= a; z++)
                        Console.Write(CHAR);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
