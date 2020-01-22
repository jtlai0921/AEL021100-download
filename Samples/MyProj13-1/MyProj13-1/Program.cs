using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_1
{
    class BaseClass
    {
        public int A;                               //宣告public欄位 (能被子類別繼承)
        private int B;                              //宣告private欄位 (不能被子類別繼承)
        protected int C;                            //宣告protected欄位 (能被子類別繼承)
        public void M1() { }                        //宣告public方法 (能被子類別繼承)
        private void M2() { }                       //宣告private方法 (不能被子類別繼承)
        protected void M3() { }                     //宣告protected方法 (能被子類別繼承)
    }

    class SubClass : BaseClass
    {
        public int X;                               //宣告public欄位 (能被子類別繼承)
        private int Y;                              //宣告private欄位 (不能被子類別繼承)
        protected int Z;                            //宣告protected欄位 (能被子類別繼承)
        public void M4() { }                        //宣告public方法 (能被子類別繼承)
        private void M5() { }                       //宣告private方法 (不能被子類別繼承)
        protected void M6() { }                     //宣告protected方法 (能被子類別繼承)
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
