using System;

namespace HomeWork4ข้อ2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Current half DNA sequence : ");
            string halfDNASequence = Console.ReadLine().ToUpper();
            if (IsValidSequence(halfDNASequence) == false)                      
            { Console.WriteLine("That half DNA sequence is invalid."); }
            else
            { Console.Write("Do you want to replicate it ? (Y/N) : ");
              char DNA1 = char.Parse(Console.ReadLine());
              switch (DNA1)
                {default:
                        do
                        {Console.Write("Please input Y or N : ");
                         DNA1 = char.Parse(Console.ReadLine());}
                        while (DNA1 == 'N' && DNA1 == 'Y');
                        if (DNA1 == 'Y')
                        {Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));}
                        break;
                    case 'Y':
                        Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));
                        break;
                    case 'N':
                        break;}}

            Console.Write("Do you want to process another sequence ? (Y/N) : ");
            char DNA2 = char.Parse(Console.ReadLine());
            switch (DNA2)
            {default:
                    do
                    {Console.Write("Please input Y or N : ");
                     DNA2 = char.Parse(Console.ReadLine());}
                    while (DNA2 == 'N' && DNA2 == 'Y');
                    if (DNA2 == 'Y')
                    {Main();}
                    break;
                case 'Y':
                    Main();
                    break;
                case 'N':
                    break;}
            Console.WriteLine("----------");
            Console.WriteLine(" End task");
            Console.WriteLine("----------");}
        //("เมธอดที่กำหนดให้ Define Method")
        static string ReplicateSeqeunce(string halfDNASequence)                  
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static bool IsValidSequence(string halfDNASequence)                      
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
