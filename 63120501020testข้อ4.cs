using System;

namespace testข้อ._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            Console.WriteLine("input float x1 :");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("input float x2 :");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("input float y1 :");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("input float y2 :");
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step; dy /= step; x = x1; y = y1;
                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine(x+y);
                    x += dx;
                    y += dy;
                }
                Console.WriteLine("End");
            }
            else
            {
                step = Math.Abs(dy);
                dx /= step; dy /= step; x = x1; y = y1;
                for (int i = 1; i <= step; i++)
                {
                    Console.WriteLine(x+y);
                    x += dx;
                    y += dy;
                }
                Console.WriteLine("End");
            }
        }
    }
}
