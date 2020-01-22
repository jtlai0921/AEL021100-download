using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj15_3
{
    class Program
    {
        static int Find<T>(T[] Array, T Value) where T : IComparable<T>
        {
            if (Array.GetLength(0) > 0)
            {
                for (int i = 0; i < Array.Length; i++)
                    //呼叫IComparable介面所宣告的CompareTo() 方法進行資料比對
                    if (Array[i].CompareTo(Value) == 0)
                        return i;                                   //找到就傳回該值位於陣列的索引
            }
            return -1;                                              //找不到就傳回 -1
        }

        static void Main(string[] args)
        {
            string[] A = { "Mon", "Tue", "Wed", "Thu", "Fri" };
            Console.WriteLine(Find(A, "Wed"));                      //傳回2表示 "Wed" 位於索引為2處
            Console.WriteLine(Find(A, "abc"));                      //傳回-1表示 "abc" 不位於陣列
            Console.ReadLine();
        }
    }
}
