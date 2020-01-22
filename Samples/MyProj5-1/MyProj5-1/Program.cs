using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_1
{
    class Calc
    {
        public void Show()
        {
            int A = Sum(5, 10);
            Console.WriteLine(A);
        }

        public int Sum(int X, int Y)
        {
            return X + Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc Obj = new Calc();
            Obj.Show();
            Console.ReadLine();
        }
    }
}
