using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] Scores = new double[8, 4] {{5, 7.7, 8, 0}, {8.8, 5.8, 8, 0}, {6, 9, 8.1, 0}, {7.6, 8.5, 9.5, 0}, {9, 9, 9.2, 0}, {4, 6.3, 7.9, 0}, {8.2, 7, 9.6, 0}, {9.1, 8.5, 8.9, 0}};
            double subTotal;                                    //此變數用來暫存每位學生的總得分
            string Result = "";                                 //此變數用來存放最後的總得分字串
            for (int i = 0; i <= 7; i++)
            {
                subTotal = 0;                                   //將暫存每位學生總得分的變數歸零
                for (int j = 0; j <= 2; j++)
                    subTotal = subTotal + Scores[i, j];         //將每輪得分累計暫存在變數subTotal
                Scores[i, 3] = subTotal;                        //將累計的總得分存放在二維陣列
            }
            for (int i = 0; i <= 7; i++)
                Result = Result + "第" + (i + 1) + "個學生的總得分為" + Scores[i, 3] + '\n';
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
