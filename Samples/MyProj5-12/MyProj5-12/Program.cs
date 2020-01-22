using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(Fibo(i));
            Console.ReadLine();
        }

        private static int Fibo(int N)
        {
            if ((N == 1) | (N == 2))
                return 1;
            else
                return Fibo(N - 1) + Fibo(N - 2);
        }
    }
}
