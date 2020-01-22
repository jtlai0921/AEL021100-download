using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_2
{
    public class Payroll
    {
        public virtual int Payment(int Hours, int PayRate)
        {
            return Hours * PayRate;
        }
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
            Payroll obj1 = new Payroll();
            BonusPayroll obj2 = new BonusPayroll();
            Console.WriteLine("尚未加上獎金的薪資為" + obj1.Payment(100, 80));
            Console.WriteLine("加上獎金之後的薪資為" + obj2.Payment(100, 80));
            Console.ReadLine();
        }
    }
}
