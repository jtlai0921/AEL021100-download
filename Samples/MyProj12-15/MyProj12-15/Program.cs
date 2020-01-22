using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_15
{
    public class Student
    {
        private string Name;

        public Student(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
    }

    public class Indexer
    {
        private const int StudentListsSize = 10;                            //這個常數為索引子大小
        private Student[] StudentLists = new Student[StudentListsSize];     //這個變數用來存放物件

        public Student this[int index]                                      //宣告索引子
        {
            get                                                             //宣告索引子的get存取子
            {
                if (index < 0 || index >= StudentListsSize) return null;
                else return StudentLists[index];
            }
            set                                                             //宣告索引子的set存取子
            {
                if (!(index < 0 || index >= StudentListsSize)) StudentLists[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Indexer Idx = new Indexer();                //建立索引子
            Idx[0] = new Student("派大星");             //將第一個物件存放到索引子的第一個元素
            Idx[1] = new Student("小丸子");             //將第二個物件存放到索引子的第二個元素
            Idx[2] = new Student("小紅豆");             //將第三個物件存放到索引子的第三個元素
            for (int i = 0; i <= 2; i++)                //使用迴圈顯示索引子內各個物件存放的姓名
                Console.WriteLine(Idx[i].GetName());
            Console.ReadLine();
        }
    }
}
