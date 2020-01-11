using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Program
    {
        private static int ParseToNumber(List<int> numbers)
        {
            string unparsedNumber = "";
            foreach (var number in numbers)
            {
                unparsedNumber += number;
            }

            return int.Parse(unparsedNumber);
        }

        static int FindNumber(int n)
        {
            List<int> numbers = new List<int>();

            if (n < 10)
            {
                return n + 10;
            }

            for (int i = 9; i >= 2; i--)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    numbers.Add(i);
                }
            }

            if (n > 10)
            {
                return -1;
            }

            numbers.Reverse();

            return ParseToNumber(numbers);
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nInput number: ");
                int input = int.Parse(Console.ReadLine());
                int output = FindNumber(input);
                Console.Write($"Output number: {output}\n");
            }
        }
    }
}
