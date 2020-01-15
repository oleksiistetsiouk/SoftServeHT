using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clock = new Clock(22, 59, 59);
            Timer timer = new Timer(0, 1, 50);

            Clock newClock = clock + timer;

            Console.WriteLine($"Clock: {clock}");
            Console.WriteLine($"Timer: {timer}");
            Console.WriteLine($"Result clock: {newClock}");

            Clock c1 = new Clock(22, 22, 24);
            Clock c2 = new Clock(22, 22, 24);

            Console.WriteLine(c1 >= c2);

            Console.ReadKey();
        }
    }
}
