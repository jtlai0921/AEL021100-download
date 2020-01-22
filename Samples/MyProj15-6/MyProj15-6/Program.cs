using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj15_6
{
    public class SampleClass
    {
        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return "生日";
            yield return "快樂";
            yield return "！";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (string str in new SampleClass())
                Console.Write(str);
            Console.ReadLine();
        }
    }
}
