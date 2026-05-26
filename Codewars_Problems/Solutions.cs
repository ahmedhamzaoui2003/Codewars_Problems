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
        // 1st method : using some logic (8 KYU)
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

        // Problem 2 : Mumbling (7 KYU)
        // 1st method : using stringBuilder()
        public static string Accum(string s)
        {
            if (s.Length < 1) return "";

            StringBuilder sb = new StringBuilder();
            int Count = 0;
            foreach (char c in s.ToLower())
            {
                sb.Append(char.ToUpper(c))
                    .Append(c, Count++)
                    .Append('-');
            }
            return sb.ToString().TrimEnd('-');
        }
        //2nd method : using normal logic 
        public static string Accum2(string s)
        {
            s = s.ToLower();
            string word = "";
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                word = "";
                for (int j = 0; j <= i; j++)
                {
                    word += s[i];
                }
                result += char.ToUpper(word[0]) + word.Substring(1) + "-";
            }
            return result.TrimEnd('-');
        }
        // Problem 3 : Fake Binary (8 KYU)

        public static string FakeBin(string x)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in x)
            {
                sb.Append(c >= '5' ? '1' : '0');
            }
            return sb.ToString();
        }

        // Problem 4 : Convert a string to an array (8 KYU)
        // 1st method : slow method (without built-in function)
        public static string[] StringToArray(string str)
        {
            List<string> arr = new List<string>();
            while (str.IndexOf(" ") != -1)
            {
                int pos = str.IndexOf(" ");
                string word = str.Substring(0, pos);
                arr.Add(word);

                str = str.Remove(0, pos + 1);
                word = "";
            }
            if (str != "")
                arr.Add(str);
            return arr.ToArray();
            
        }

        //2nd method : fast and using Split() function 
        public static string[] StringToArray2(string str)
        {
            return str.Split(' ');
        }

    }
}
