using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_row, A = 1, B, i, j;
            Console.WriteLine("Please input number to find the Pascal's triangle");
            Console.Write("Input number of rows : ");
            num_row = int.Parse(Console.ReadLine());
            while (num_row < 0)
                { Console.WriteLine("Invalid Pascal's triangle row number.");
                Console.Write("Input number of rows : ");
                num_row = int.Parse(Console.ReadLine()); }
            Console.WriteLine("--------------------------------------------");
            for (i = 0; i <= num_row; i++)
                {for (B = 1; B <= num_row - i; B++)
                        Console.Write("");
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            A = 1;
                        else
                            A = A * (i - j + 1) / j;
                        Console.Write(A+" ");
                    }
                    Console.WriteLine();
                }
            
            Console.ReadLine();
        }
    }
}
