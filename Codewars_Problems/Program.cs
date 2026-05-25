using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Problems
{
    internal class Program
    {
        public static string Accum(string s)
        {
            if (s.Length < 1)  return "";

            StringBuilder sb = new StringBuilder();
            int Count = 0;
            foreach(char c in s.ToLower())
            {
                sb.Append(char.ToUpper(c))
                    .Append(c, Count++)
                    .Append('-');
            }
            return sb.ToString().TrimEnd('-');
        }
        public static string Accum2(string s)
        {
            s = s.ToLower();
            string word = "";
            string result = "";
            for(int i = 0; i < s.Length; i++)
            {
                word = "";
                for(int j = 0; j <= i; j++)
                {
                    word += s[i];
                }
                result += char.ToUpper(word[0]) + word.Substring(1) + "-";
            }
            return result.TrimEnd('-'); 
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Accum("abcd"));
        }
    }
}
