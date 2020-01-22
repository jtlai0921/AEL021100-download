using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj14_3
{
    class Program
    {
        public delegate bool IsLarger(int X, int Y);

        public static bool MyIsLarger(int X, int Y)
        {
            if (X > Y) return true;
            else return false;
        }

        public static void DoSort(ref int[] Data, IsLarger LargerThan)
        {
            int Temp;
            for (int i = 0; i <= Data.GetUpperBound(0); i++)
                for (int j = i + 1; j <= Data.GetUpperBound(0); j++)
                    if (LargerThan(Data[i], Data[j]) == true)
                    {
                        Temp = Data[i];
                        Data[i] = Data[j];
                        Data[j] = Temp;
                    }
        }

        static void Main(string[] args)
        {
            int[] Data = new int[5] { 12, 3, 8, 55, 25 };			//宣告欲進行排序的陣列
            IsLarger Larger = new IsLarger(MyIsLarger);	            //建立委派的物件
            DoSort(ref Data, Larger);								//呼叫排序方法
            for (int i = 0; i <= Data.GetUpperBound(0); i++)		//顯示排序完畢的陣列
                Console.WriteLine(Data[i]);
            Console.ReadLine();
        }
    }
}
