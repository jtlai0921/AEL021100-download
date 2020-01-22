using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Scores = { 85, 60, 54, 91, 100, 77 };
            int MaxScore = 0, MinScore = 100;

            //使用迴圈找出最高分
            foreach (int Item in Scores)
                if (Item > MaxScore) MaxScore = Item;

            //使用迴圈找出最低分
            foreach (int Item in Scores)
                if (Item < MinScore) MinScore = Item;

            Console.WriteLine("最高分為" + MaxScore);
            Console.WriteLine("最低分為" + MinScore);
            Console.ReadLine();
        }
    }
}
