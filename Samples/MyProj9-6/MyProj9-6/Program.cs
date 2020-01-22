using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProj9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream objFileStream = new FileStream(@"D:\Poetry3.txt", FileMode.Open, FileAccess.Read);
            byte[] MyByteArray = new byte[objFileStream.Length];
            string Content = "";
            objFileStream.Read(MyByteArray, 0, System.Convert.ToInt32(objFileStream.Length));
            foreach (byte MyByte in MyByteArray)
                Content = Content + System.Convert.ToChar(MyByte);
            Console.Write(Content);
            objFileStream.Close();
            Console.ReadLine();
        }
    }
}
