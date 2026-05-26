using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Problems
{
    internal class Program
    {
        public static string[] StringToArray(string str)
        {
            List<string> arr = new List<string>();
            while(str.IndexOf(" ") != -1)
            {
                int pos = str.IndexOf(" ");
                string word = str.Substring(0, pos);
                arr.Add(word);

                str = str.Remove(0, pos+1);
                word = "";
            }
            if (str != "")
                arr.Add(str);
            return arr.ToArray();




            /*return str.Split(' ');*/
        }

        static void Main(string[] args)
        {
            string[] words = StringToArray("I love arrays they are my favorite");
            foreach(string s in words)
                Console.Write(s);
        }
    }
}
