using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 1;
            for (int i = 1; i <= 5; i++)
                Result *= i;
            Console.WriteLine("5! = " + Result);
            Console.ReadLine();
        }
    }
}
