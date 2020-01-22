using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProj9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter objWriter = new StreamWriter(@"D:\MyText.txt", true);
            objWriter.WriteLine("這是使用WriteLine() 方法加入第一行文字");
            objWriter.WriteLine();      //加入空白行
            objWriter.WriteLine("這是使用WriteLine() 方法加入第二行文字");
            objWriter.WriteLine();      //加入空白行
            objWriter.WriteLine("這是使用WriteLine() 方法加入第三行文字");
            objWriter.Close();
        }
    }
}
