using System;

namespace ข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cannot use float because not enough values ​​are stored so double is used.");
            string mode = Console.ReadLine();
            double flimBlackWidth = double.Parse(Console.ReadLine());

            if (flimBlackWidth > 0)
            {
                double flenght, fov;
                if (mode == "flenght")
                {
                    flenght = double.Parse(Console.ReadLine());
                    if (flenght > 0)
                    {
                        fov = 2 * Math.Atan(flimBlackWidth / (2 * flenght));
                        Console.WriteLine("flenght = "+ flenght);
                        Console.WriteLine("fov = "+ fov);
                    }
                    else
                    {Console.WriteLine("Invalid flenght Please input again. ");}
                }
                else if (mode == "fov")
                {
                    fov = double.Parse(Console.ReadLine());
                    if (fov > 0.1 && fov < 6.28)
                    {
                        flenght = flimBlackWidth / (2 * Math.Tan(fov / 2));
                        Console.WriteLine("flenght = "+ flenght);
                        Console.WriteLine("fov = " + fov);
                    }
                    else
                    {Console.WriteLine("Invalid fov Please input again ");}
                }

            }
            else
            {Console.WriteLine("Invalid blackflim width please try again");}
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
