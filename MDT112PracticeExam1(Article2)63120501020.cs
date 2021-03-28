using System;

namespace MDT112PracticeExam1_2_63120501020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input Number b : ");
            int b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            while (x != y) 
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine("x = "+x);
            Console.ReadLine();
        }
    }
}
