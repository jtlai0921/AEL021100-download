using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入「快樂」的英文");
            string Answer = Console.ReadLine();         //讀取輸入並存放在變數Answer
            while (Answer.ToUpper() != "HAPPY")         //ToUpper() 可以將字串轉換為大寫
            {
                Console.WriteLine("請輸入「快樂」的英文");
                Answer = Console.ReadLine();            //讀取輸入並存放在變數Answer
            }
            Console.WriteLine("答對了！");
            Console.ReadLine();
        }
    }
}
