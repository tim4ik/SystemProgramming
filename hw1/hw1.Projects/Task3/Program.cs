using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int dig1 = int.Parse(args[0]);
                string op = args[1];
                int dig2 = int.Parse(args[2]);
                switch (op)
                {
                    case "+":
                        Console.WriteLine(dig1 + dig2);
                        break;
                    case "-":
                        Console.WriteLine(dig1 - dig2);
                        break;
                    case "*":
                        Console.WriteLine(dig1 * dig2);
                        break;
                    case "/":
                        Console.WriteLine(dig1 / dig2);
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
