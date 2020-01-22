using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_2
{
    class Calc
    {
        public static void Show()
        {
            int A = Sum(5, 10);
            Console.WriteLine(A);
        }

        public static int Sum(int X, int Y)
        {
            return X + Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc.Show();
            Console.ReadLine();
        }
    }
}
