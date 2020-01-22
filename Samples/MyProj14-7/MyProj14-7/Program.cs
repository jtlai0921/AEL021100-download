using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj14_7
{
    public delegate void EmployeeEventHandler(object source, EmployeeEventArgs args);

    public class Employee                                           //此為事件發送者
    {
        private string EmpName;
        public event EmployeeEventHandler EmpEvent; //建立事件委派的物件

        public void Add(string Str)
        {
            EmpName = Str;
            if (EmpEvent != null)                                       //檢查是否有連結事件程序
                EmpEvent(this, new EmployeeEventArgs(Str)); //呼叫事件委派的物件以觸發事件
        }
    }

    public class EmployeeEventArgs : EventArgs      //事件委派第二個參數的類別
    {
        public string Name;
        public EmployeeEventArgs(string Str)
        {
            Name = Str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            E1.EmpEvent += new EmployeeEventHandler(ShowName);      //連結事件程序
            E1.Add("小丸子");                                       //這會觸發事件
        }

        public static void ShowName(object source, EmployeeEventArgs args)  //宣告事件程序
        {
            Console.WriteLine(args.Name + "被加入Employee物件");
            Console.ReadLine();
        }
    }
}
