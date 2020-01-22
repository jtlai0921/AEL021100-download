using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj14_2
{
    public struct Vector
    {
        private double x, y, z;
        public Vector(double a, double b, double c)     //根據參數的值設定三維向量的x、y、z
        {
            this.x = a;
            this.y = b;
            this.z = c;
        }

        public override string ToString()                   //覆蓋ToString() 方法以顯示三維向量的值
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            Vector vec3 = new Vector((vec1.x + vec2.x), (vec1.y + vec2.y), (vec1.z + vec2.z));
            return vec3;
        }

        public static Vector operator *(double a, Vector vec1)
        {
            Vector vec2 = new Vector(a * vec1.x, a * vec1.y, a * vec1.z);
            return vec2;
        }

        public static Vector operator *(Vector vec1, double b)
        {
            Vector vec2 = new Vector(vec1.x * b, vec1.y * b, vec1.z * b);
            return vec2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(1, 2, 2);
            Vector vec2 = new Vector(5, -8, -4);
            Vector vec3 = vec1 + vec2;
            Vector vec4 = 10 * vec1;
            Vector vec5 = vec1 * 5;
            Console.WriteLine("第一個三維向量為" + vec1.ToString());
            Console.WriteLine("第二個三維向量為" + vec2.ToString());
            Console.WriteLine("第三個三維向量為" + vec3.ToString());
            Console.WriteLine("第四個三維向量為" + vec4.ToString());
            Console.WriteLine("第五個三維向量為" + vec5.ToString());
            Console.ReadLine();
        }
    }
}
