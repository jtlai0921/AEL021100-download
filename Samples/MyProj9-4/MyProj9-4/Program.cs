using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProj9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader(@"D:\Poetry1.txt", System.Text.Encoding.Unicode);
            string MyLine = objReader.ReadLine();               //從檔案指標的位置讀取一行
            while (MyLine != null)                              //檢查是否碰到檔案結尾
            {
                Console.WriteLine(MyLine);
                MyLine = objReader.ReadLine();
            }
            objReader.Close();									//關閉檔案
            Console.ReadLine();
        }
    }
}
