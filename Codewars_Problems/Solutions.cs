using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Problems
{
    internal class Solutions
    {
        // Problem 1 : You only need one - Beginner
        // 1st method : using some logic 
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
        // 2nd method : using built-in function (join) 
        public static string Smash2(string[] words)
        {
            return string.Join(" ",words);
        }


    }
}
