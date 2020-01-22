using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using colAlias = System.Collections;

namespace MyProj12_17
{
    class Program
    {
        static void Main(string[] args)
        {
            colAlias::ArrayList AL = new colAlias::ArrayList();
            AL.Add("甲");
            AL.Add("乙");
            AL.Add("丙");
            foreach (string Name in AL)
                global::System.Console.WriteLine(Name);
            Console.ReadLine();
        }
    }
}
