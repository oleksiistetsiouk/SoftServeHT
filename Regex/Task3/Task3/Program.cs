using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = null;

            using (StreamReader sr = new StreamReader(@"text.txt"))
            {
                @string = sr.ReadToEnd();
            }

            Console.WriteLine(@string);

            string pattern = @"(.*)(\r?\n\1)";
            string target = "$1\n";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(@string, target);

            Console.WriteLine($"\n\nResult:\n{result}");

            Console.ReadKey();
        }
    }
}
