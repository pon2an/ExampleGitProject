using System;
using System.IO;
namespace _6666
{
    class Program
    {
        static void Main(string[] args)
        {//ได้โปรดเมตตาด้วย i will daed
            Console.WriteLine(" Please input a number from 0 - 3 to choose the following menu : ");
            Console.WriteLine(" [0] Show all recent files ");
            Console.WriteLine(" [1] Open new file ");
            Console.WriteLine(" [2] Open recent file ");
            Console.WriteLine(" [3] Exit ");

            Console.Write("Your select: ");
            string choice = Console.ReadLine();

            StreamWriter file = null;
            file = null;
            string fileName = @"TextFile1.txt";
            string line = null;

            Console.Write("Enter your message: ");
            line = Console.ReadLine();
            file.WriteLine(line);
            try
            {
                if (choice == "0")
                { file = new StreamWriter(fileName); }
                else if (choice == "1")
                { file = File.AppendText(fileName); }
                else if (choice == "2")
                { file = File.CreateText(fileName); }
                else if (choice == "3")
                { file.Close(); }
                else
                { Console.WriteLine(" Invalid menu number."); }

                file.WriteLine(line);
            }

            catch (FileNotFoundException e)
            {   Console.WriteLine("“No recent file.”"); }

            finally
            {
                if (file != null)
                { file.Close(); }
            }

            file.Close();

        }
    }
}
