using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input PRICE : ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("input VAT% : "); //Thai VAT 7%
            double B = Convert.ToDouble(Console.ReadLine());
            double C = A + (A * B / 100);
            Console.WriteLine("NET PRICE : " + C);
            Console.ReadLine();
        }
    }
}
