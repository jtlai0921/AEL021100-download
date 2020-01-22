using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj15_4
{
    public class NamesOfTheStudents : System.Collections.IEnumerable
    {
        string[] Names = { "小丸子", "花輪", "丸尾" };
        public System.Collections.IEnumerator GetEnumerator()
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
            //foreach會呼叫NamesOfTheStudents.GetEnumerator() 方法逐一取得值
            foreach (string name in obj)
                System.Console.Write(name + "\n");
            Console.ReadLine();
        }
    }
}
