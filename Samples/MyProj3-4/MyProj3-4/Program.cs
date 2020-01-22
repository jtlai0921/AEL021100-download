using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Chinese, English, Math;
          L1:
            Console.WriteLine("請輸入國文成績(0-100)：");
            Chinese = System.Convert.ToInt32(Console.ReadLine());
            if ((Chinese < 0) | (Chinese > 100)) goto L1;
          L2:
            Console.WriteLine("請輸入英文成績(0-100)：");
            English = System.Convert.ToInt32(Console.ReadLine());
            if ((English < 0) | (English > 100)) goto L2;
          L3:
            Console.WriteLine("請輸入數學成績(0-100)：");
            Math = System.Convert.ToInt32(Console.ReadLine());
            if ((Math < 0) | (Math > 100)) goto L3;
            Console.WriteLine("總分為" + (Chinese + English + Math));
            Console.ReadLine();
        }
    }
}
