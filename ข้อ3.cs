using System;

namespace _333
{
    class Program
    {
        static void Main(string[] args)
        {//ไม่รู้ววววววว อ้ากกกกกกก ทำไม่ทันนนน
            Console.Write("input your number : ");
            string num = Console.ReadLine();
            Type[] numarray = new Type[9999999];
            do
            {   Console.Write("number : ");
                num = Console.ReadLine();} 
            while (num != "End");

            if (num == "End")
            {   Console.WriteLine(" ");
                string f = Console.ReadLine();}

            Console.WriteLine(Math.Max(num));
            Console.WriteLine(Math.Min(num));

            //Console.Write("input your number (x) : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("input your number (y) : ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //Console.Write("Maximum number : ");
            //Console.WriteLine(Math.Max(num1, num2));
            //Console.Write("Minimum number : ");
            //Console.WriteLine(Math.Min(num1, num2));
        }
        static void Numinfo(double AllNow, int ABCD) { }

    }
}