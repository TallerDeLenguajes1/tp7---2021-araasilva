using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] miVariable = System.IO.Directory.GetLogicalDrives();

            for (int i = 0; i < miVariable.Length; i++)
            {
                Console.WriteLine(miVariable[i]);
            }
        }
    }
}
