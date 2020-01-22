using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter file = null;
            try
            {
                file = new System.IO.StreamWriter(@"C:\file1.txt");
                file.WriteLine("Hello, world!");
            }
            catch (UnauthorizedAccessException e1)
            {
                System.Console.WriteLine("捕捉到UnauthorizedAccessException例外，錯誤訊息為" + e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine("捕捉到其它例外，錯誤訊息為" + e2.Message);
            }
            finally
            {
                if (file != null) file.Close();                
            }
            Console.ReadLine();
        }
    }
}
