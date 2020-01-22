using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProj9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string Name in Directory.GetDirectories(@"C:\Windows"))
                Console.WriteLine(Name);
            Console.ReadLine();
        }
    }
}
