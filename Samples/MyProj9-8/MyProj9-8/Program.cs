using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProj9_8
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader(@"D:\Sample1.txt");
            StreamWriter objWriter = new StreamWriter(@"D:\Sample2.txt");
            string Line = objReader.ReadLine();
            while (Line != null)
            {
                objWriter.WriteLine(Line);
                Line = objReader.ReadLine();
            }
            objReader.Close();
            objWriter.Close();
        }
    }
}
