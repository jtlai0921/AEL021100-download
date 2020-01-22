using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1;
            Increase(Num);
            Console.WriteLine("方法執行完畢後原參數值為" + Num);
            Console.ReadLine();
        }

        private static void Increase(int Result)
        {
            Console.WriteLine("方法剛被呼叫時的參數值為" + Result);
            Result += 1;
            Console.WriteLine("方法執行完畢後的參數值為" + Result);
        }
    }
}
