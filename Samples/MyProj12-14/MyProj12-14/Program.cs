using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_14
{
    public class Student
    {
        private string Name;

        public Student(string Name)     //這是Student類別的建構函式
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] StudentLists = new Student[3];
            StudentLists[0] = new Student("派大星");
            StudentLists[1] = new Student("小丸子");
            StudentLists[2] = new Student("小紅豆");
            foreach (Student Item in StudentLists)
                Console.WriteLine(Item.GetName());
            Console.ReadLine();
        }
    }
}
