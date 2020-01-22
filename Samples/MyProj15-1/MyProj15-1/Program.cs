using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Dinosaurs = new List<string>();
            Dinosaurs.Add("雷龍");
            Dinosaurs.Add("劍龍");
            Dinosaurs.Add("暴龍");
            foreach (string Dinosaur in Dinosaurs)
                Console.WriteLine(Dinosaur);
            Console.ReadLine();
        }
    }
}
