using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_parent
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\Users\\ttopa\\source\\repos\\SystemProgramming\\hw1\\hw1.Projects\\Task4_parent\\child\\Task4_child.exe";
            proc.StartInfo.Arguments = "D:\\text2.txt bicycle";
            proc.Start();
        }
    }
}
