using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_parent
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\Users\\ttopa\\source\\repos\\SystemProgramming\\hw1\\hw1.Projects\\Task3_parent\\child\\Task3.exe";
            proc.StartInfo.Arguments = "16 / 8";
            proc.Start();
        }
    }
}
