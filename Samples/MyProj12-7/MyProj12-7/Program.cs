using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj12_7
{
    public class Quad
    {
        private int Width, Height;

        public Quad()
        {
            Width = 10;
            Height = 10;
        }

        public Quad(int D)
        {
            Width = D;
            Height = D;
        }

        public Quad(int W, int H)
        {
            Width = W;
            Height = H;
        }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Quad Q1 = new Quad();
            Quad Q2 = new Quad(20);
            Quad Q3 = new Quad(30, 40);
            Console.WriteLine("第一個方形的面積為" + Q1.GetArea());
            Console.WriteLine("第二個方形的面積為" + Q2.GetArea());
            Console.WriteLine("第三個方形的面積為" + Q3.GetArea());
            Console.ReadLine();
        }
    }
}
