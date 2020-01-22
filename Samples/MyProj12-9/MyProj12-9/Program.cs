using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_9
{
    public class Counter
    {
        private Counter() { }
        public static int currentCount;
        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter.currentCount = 100;
            Counter.IncrementCount();
            Console.WriteLine("新的count值為 {0}", Counter.currentCount);
            Console.ReadLine();
        }
    }
}
