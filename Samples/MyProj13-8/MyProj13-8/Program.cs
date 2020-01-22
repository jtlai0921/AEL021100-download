using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj13_8
{
    public abstract class Transport
    {
        public abstract void Launch();
        public abstract void Park();
    }

    public class Bicycle : Transport
    {
        public override void Launch()
        {
            //在此寫上發動腳踏車的程式碼
        }
        public override void Park()
        {
            //在此寫上停止腳踏車的程式碼
        }
    }

    public class Motorcycle : Transport
    {
        public override void Launch()
        {
            //在此寫上發動摩扥車的程式碼
        }
        public override void Park()
        {
            //在此寫上停止摩扥車的程式碼
        }
    }

    public class Car : Transport
    {
        public override void Launch()
        {
            //在此寫上發動汽車的程式碼
        }
        public override void Park()
        {
            //在此寫上停止汽車的程式碼
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
