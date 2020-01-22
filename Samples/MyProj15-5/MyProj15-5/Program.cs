using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj15_5
{
    public class NamesOfTheStudents
    {
        string[] Names = { "小丸子", "花輪", "丸尾" };
        public System.Collections.IEnumerable Iterator1()
        {
            for (int i = 0; i < Names.Length; i++)
                yield return Names[i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NamesOfTheStudents obj = new NamesOfTheStudents();
            //在foreach內呼叫具名的Iterator逐一取得值
            foreach (string name in obj.Iterator1())
                System.Console.Write(name + "\n");
            Console.ReadLine();
        }
    }
}
