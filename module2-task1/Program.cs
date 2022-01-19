using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2
{
    class Program
    {
        static void Main(string[] args)
        {

            var Fname = "Ira";
            var Lname = "Xtz";
            var age = 25;
            var spec = "IT-recruter";
            string pattern = "Hi, my name is {0}.\nI`m {1} years old.\nI wana be {2}";
            byte u = 255;
            double d = 12345.123_456_789_123_456_78;

            //Console.WriteLine("Hi, my name is {0} " + Lname + $". I`m {age} years old. " + "My spec is {1}.", Fname, spec);
            //Console.WriteLine(pattern, Fname, age, spec);
            //Console.WriteLine(d.ToString("#.###"));
            Console.WriteLine("{0}",u);
            Console.ReadKey();

        }
    }
}
