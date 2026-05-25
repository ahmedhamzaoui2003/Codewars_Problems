using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Problems
{
    internal class Program
    {
        public static string FakeBin(string x)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in x)
            {
                sb.Append(c >= '5' ? '1' : '0');
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FakeBin("51483"));
        }
    }
}
