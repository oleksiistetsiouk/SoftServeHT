using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void FindDates(string inputString)
        {
            Regex regex = new Regex(@"([1]\d{3}|200\d|201[123])/(0\d|1[0-2])/([0-2]\d|3[0]) (0\d|1\d|2[0-4]):([0-5][0-9])");
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
            Console.WriteLine("Please, enter date in format \"YYYY/MM/DD hh:mm\"");
            Console.WriteLine("Date should be between 1000/01/01 and 2013/12/30");

            while (true)
            {
                Console.Write("\nEnter date: ");
                string date = Console.ReadLine();
                FindDates(date);
            }
        }
    }
}
