using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Problems
{
    internal class Program
    {

        public static string Smash(string[] words)
        {
            string s = "";
            foreach (string w in words)
            {
                s += w + " ";
            }
            s = s.Substring(0, s.Length - 1);
            return s;
        }

        static void Main(string[] args)
        {
            string[] words = { "hello", "world", "this", "is", "great" };
            Console.WriteLine(Smash(words));
        }
    }
}
