using System;

namespace MDT112PracticeExam1_3_63120501020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of boxes in bucket 1 : ");
            int box1 = int.Parse(Console.ReadLine());
            Console.Write("Number of boxes in bucket 2 : ");
            int box2 = int.Parse(Console.ReadLine());
            Console.Write("Number of boxes in bucket 3 : ");
            int box3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            do
            {
                Console.WriteLine("***** bucket(1) = " + box1 + "  ||  bucket(2) = " + box2 + "  ||  bucket (3) = " + box3 + "  *****");
                Console.WriteLine("*** Player A ***");
                Console.Write("Choose number bucket (1) (2) (3) : ");
                int ChooseA = int.Parse(Console.ReadLine());
                switch (ChooseA)
                {
                    case 1:
                        Console.Write("Choose number of boxes to be picked out (1-2) : ");
                        int outA = int.Parse(Console.ReadLine());
                        if (outA > 0 && outA < 3)
                        { box1 = box1 - outA; }
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.Write("Choose number of boxes to be picked out (1-2) : ");
                        outA = int.Parse(Console.ReadLine());
                        if (outA > 0 && outA < 3)
                        { box2 = box2 - outA; }
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.Write("Choose number of boxes to be picked out (1-2) : ");
                        outA = int.Parse(Console.ReadLine());
                        if (outA > 0 && outA < 3)
                        { box3 = box3 - outA; }
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Please input agian (1-3) Next turn!");
                        Console.WriteLine("");
                        break;

                }
                if (box1 == 0 && box2 == 0 && box3 == 0)
                {
                    Console.WriteLine("A win Yeppyyyyyyy");
                }
                else
                {
                    Console.WriteLine("***** bucket(1) = " + box1 + "  ||  bucket(2) = " + box2 + "  ||  bucket (3) = " + box3 + "  *****");
                    Console.WriteLine("*** Player B ***");
                    Console.Write("Choose number bucket (1) (2) (3) : ");
                    int ChooseB = int.Parse(Console.ReadLine());
                    switch (ChooseB)
                    {
                        case 1:
                            Console.Write("Choose number of boxes to be picked out (1-2) : ");
                            int outB = int.Parse(Console.ReadLine());
                            if (outB > 0 && outB < 3)
                            { box1 = box1 - outB; }
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.Write("Choose number of boxes to be picked out (1-2) : ");
                            outB = int.Parse(Console.ReadLine());
                            if (outB > 0 && outB < 3)
                            { box2 = box2 - outB; }
                            Console.WriteLine("");
                            break;

                        case 3:
                            Console.Write("Choose number of boxes to be picked out (1-2) : ");
                            outB = int.Parse(Console.ReadLine());
                            if (outB > 0 && outB < 3)
                            { box3 = box3 - outB; }
                            Console.WriteLine("");
                            break;

                        default:
                            Console.WriteLine("Please input agian (1-3) Next turn!");
                            Console.WriteLine("");
                            break;
                    }
                    if (box1 == 0 && box2 == 0 && box3 == 0)
                    {
                        Console.WriteLine("B win Yahoooo");
                    }
                }
            }
            while (box1 != 0 || box2 != 0 || box3  != 0);
            Console.ReadLine();
        }
    }
}
