using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_8
{
    class Program
    {
        static int Result = 0;
        static void Main(string[] args)
        {
            Add();
            Add();
            Console.ReadLine();
        }

        private static void Add()
        {
            Result = Result + 1;
            Console.WriteLine(Result);
        }
    }
}
