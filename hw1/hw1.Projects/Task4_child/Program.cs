using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_child
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            string substr = args[1];
            var sr = new StreamReader(filePath);
            string text = sr.ReadToEnd();
            int cnt = 0;
            for (int i=0;i<text.Length-substr.Length;i++)
            {
                if (text.Substring(i, substr.Length) == substr)
                    cnt++;
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
