using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProj9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"D:\MyDir";
            if (Directory.Exists(Path) == false) Directory.CreateDirectory(Path);
            Console.WriteLine("資料夾建立時間：" + Directory.GetCreationTime(Path));
            Console.WriteLine("資料夾最後存取時間：" + Directory.GetLastAccessTime(Path));
            Console.WriteLine("資料夾的根目錄：" + Directory.GetDirectoryRoot(Path));
            Console.ReadLine();

            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.InvalidPathChars);
            Console.WriteLine(Path.PathSeparator);
            Console.ReadLine();
        }
    }
}
