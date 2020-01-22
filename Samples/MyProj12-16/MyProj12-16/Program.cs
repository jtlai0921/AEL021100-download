using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_16
{
    public class TwoDimArray
    {
        //這些變數為二維陣列的第一維及第二維的大小
        private int Size_i, Size_j;
        //這個一維陣列即將用來存放二維陣列
        private System.Array MyArray;

        public TwoDimArray(int Si, int Sj)
        {
            Size_i = Si;
            Size_j = Sj;
            //根據二維陣列的第一維及第二維的大小配置一維陣列的空間
            MyArray = System.Array.CreateInstance(typeof(object), Size_i * Size_j);
        }

        public object this[int i, int j]                //宣告索引子
        {
            get                                         //宣告索引子的get存取子
            {
                int k = i * Size_i + j;
                return MyArray.GetValue(k);
            }
            set                                         //宣告索引子的set存取子
            {
                int k = i * Size_i + j;
                MyArray.SetValue(value, k);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TwoDimArray Arr = new TwoDimArray(5, 5);
            Arr[1, 2] = "Happy";
            Arr[3, 4] = "Birthday";
            Console.WriteLine("Arr[1, 2]的值為" + Arr[1, 2]);
            Console.WriteLine("Arr[3, 4]的值為" + Arr[3, 4]);
            Console.ReadLine();
        }
    }
}
