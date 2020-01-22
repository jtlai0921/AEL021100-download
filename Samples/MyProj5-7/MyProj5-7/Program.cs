using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Console.ReadLine();
        }

        private static void Add()
        {
            int Result = 0;
            Result = Result + 1;
            Console.WriteLine(Result);
        }
    }
}
