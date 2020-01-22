using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_4
{
    class Demo
    {
        static int Answer = 0;
        public static int Number                        //宣告靜態屬性
        {
            get                                         //宣告get存取子以傳回屬性值
            {
                return Answer;
            }
            set                                         //宣告set存取子以設定屬性值
            {
                if (value < 50) Answer = value;         //value為set存取子的隱含參數
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo.Number = 25;                           //透過類別的名稱設定靜態屬性的值
            Console.WriteLine(Demo.Number);             //透過類別的名稱取得靜態屬性的值
            Console.ReadLine();
        }
    }
}
