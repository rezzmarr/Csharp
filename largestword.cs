using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace largestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("This is a test, obviously. hello_world_team..."));
            Console.ReadLine();
        }


        public static string LongestWord(string sen)
        {
            string[] items = Regex.Split(sen, @"[^a-zA-Z]+");

            string largestword = "";
            int largestsize = 0;

            foreach (string item in items)
            {
                if (item.Length > largestsize) {
                    largestword = item;
                    largestsize = item.Length;
                }
    }

            return largestword;

        }
    }
}
