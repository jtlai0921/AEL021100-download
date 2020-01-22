using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentScores("小丸子", "90", "80", "缺席", "70");
            Console.ReadLine();
        }

        private static void StudentScores(string Name, params string[] Scores)
        {
            Console.WriteLine(Name + "的分數如下:");
            for (int i = 0; i <= Scores.GetUpperBound(0); i++)  
                Console.WriteLine(Scores[i]);
        }
    }
}
