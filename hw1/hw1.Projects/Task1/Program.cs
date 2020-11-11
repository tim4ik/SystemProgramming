using System;
using System.Diagnostics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "mspaint.exe";
            proc.Start();
            Console.WriteLine("Process started");
            proc.WaitForExit();
            Console.WriteLine("Exit code: " + proc.ExitCode);
        }
    }
}
