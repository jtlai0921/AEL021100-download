using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 100, Y = 0, Z = 5;
            try
            {
                Z = X / Y;
            }
            catch (Exception e)
            {
                Console.WriteLine("捕捉到" + e.GetType() + "例外，錯誤訊息為" + e.Message);
            }
            finally
            {
                Console.WriteLine("Z的值為" + Z);
            }
            Console.ReadLine();
        }
    }
}
