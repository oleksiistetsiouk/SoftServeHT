using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void IPAddresses(string inputString)
        {
            Regex regex = new Regex(@"(^\d{2}|0x\w[a-f]).(1\d{2}|2[1-5][1-5]).(1\d{2}|2[1-5][1-5]).(\d{3}|0x\d{2})", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(inputString);
            if (matches.Count > 0)
            {
                Console.WriteLine("Found matches:");
                foreach (Match match in matches)
                    Console.WriteLine($"\t{match.Value}");
            }
            else
            {
                Console.WriteLine("Matches not found");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter IPv4 address in decimal or hex format");

            while (true)
            {
                Console.Write("\nEnter IP address: ");
                string date = Console.ReadLine();
                IPAddresses(date);
            }
        }
    }
}
