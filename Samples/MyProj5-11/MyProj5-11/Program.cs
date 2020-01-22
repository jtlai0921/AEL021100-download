using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("84和1080的最大公因數為" + GCD(84, 1080));
            Console.ReadLine();
        }

        private static int GCD(int M, int N)
        {
            if ((M % N) == 0)
                return N;
            else
                return GCD(N, M % N);
        }
    }
}
