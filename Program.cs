using System;

namespace homework63120501020Anan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input mode : ");
            string mode = Console.ReadLine();
            Console.Write("Please input number x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please input number y : ");
            double y = double.Parse(Console.ReadLine());

            double Time = Math.Pow(x - 1, 2);
            double Price = Math.Sqrt(y) + 1;

            if (x > 0)
            {
                switch (mode)
                
                 {case "time":
                      Console.WriteLine("time = " + x + " , " + Time);
                  break;
                  case "price":
                      Console.WriteLine("price = " + Price + "," + y);
                  break;
                  default:
                      Console.WriteLine("Invalid mode");
                  break; }
                
            }
            else { Console.WriteLine("Invalid mouse position"); }

            Console.ReadLine();
        }
    }
}
