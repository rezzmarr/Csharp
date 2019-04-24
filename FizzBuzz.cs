using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            outputFizzBuzz();
            Console.ReadKey();
        }

        static void outputFizzBuzz()
        {
            Dictionary<int, String> pairs = new Dictionary<int, String>();
            pairs[3] = "Fizz";
            pairs[5] = "Buzz";
            pairs[6] = "Wizz";

            for (int number = 1; number <= 100; number++)
            {
                Boolean match = false;
                foreach (int key in pairs.Keys)
                {
                    if (number % key == 0)
                    {
                        Console.Write(pairs[key]);
                        match = true;
                    }
                }
                if(match == false) { Console.Write(number); }
                Console.WriteLine();
            }
        }
    }
}
