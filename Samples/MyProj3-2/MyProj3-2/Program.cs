using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { "張大明", "孫小美", "小丸子" };
            foreach (string Str in Names)
                Console.WriteLine(Str);
            Console.ReadLine();
        }
    }
}
