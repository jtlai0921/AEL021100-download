using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj5_14
{
    public class Student
    {
        private string StudentName;         //學生姓名
        private int StudentScore;           //學生分數

        public string Name
        {
            set
            {
                StudentName = value;
            }
            get
            {
                return StudentName;
            }
        }

        public int Score
        {
            set
            {
                if (value < 60) StudentScore = 60;
                else StudentScore = value;
            }
            get
            {
                return StudentScore;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ST = new Student();
            ST.Name = "Mary";
            ST.Score = 50;
            Console.WriteLine(ST.Name + "的分數為" + ST.Score);
            Console.ReadLine();
        }
    }
}
