using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5! = " + F(5));
            Console.ReadLine();
        }

        private static int F(int N)
        {
            if (N == 0)
                return 1;                       //當N = 0時，F(N) = N! = 0! = 1
            else if (N > 0)
                return N * F(N - 1);            //當N > 0時，F(N) = N! = N * F(N - 1)
            else
                return -1;                      //當N < 0時，F(N) = -1，表示N為負數
        }
    }
}
