using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_12
{
    class C : IDisposable
    {
        public void UseLimitedResource()
        { Console.WriteLine("物件正在使用資源..."); }

        public void Dispose()
        { Console.WriteLine("正在釋放佔用的資源."); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (C c = new C())
            {
                c.UseLimitedResource();
            }
            Console.WriteLine("目前已經離開using區塊.");
            Console.ReadLine();
        }
    }
}
