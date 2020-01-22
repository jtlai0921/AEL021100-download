using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ReturnArray;
            ReturnArray = ExpValue(10);
            foreach (int Item in ReturnArray)
                Console.WriteLine(Item);
            Console.ReadLine();
        }

        private static int[] ExpValue(int A)
        {
            int[] X = new int[3];
            X[0] = A;
            X[1] = A * A;
            X[2] = A * A * A;
            return X;
        }
    }
}
