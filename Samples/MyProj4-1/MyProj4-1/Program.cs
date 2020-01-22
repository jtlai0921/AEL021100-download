using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Scores = { 90, 86, 99, 54 };
            foreach (int Item in Scores)
                Console.WriteLine(Item);
            Console.ReadLine();
        }
    }
}
