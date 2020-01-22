using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_4
{
    public abstract class Payroll
    {
        public abstract int Payment(int Hours, int PayRate);
    }

    public class BonusPayroll : Payroll
    {
        public override int Payment(int Hours, int PayRate)
        {
            return Hours * PayRate + 1000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BonusPayroll obj = new BonusPayroll();
            Console.WriteLine("加上獎金之後的薪資為" + obj.Payment(100, 80));
            Console.ReadLine();
        }
    }
}
