using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2_taks1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Николетта Фрост";
            byte age = 17;
            double PointPrograming = 56.2;
            double PointMath = 26.8;
            double PointPhysics = 76.3;

            string pattern = "{0}, {1} лет.\nРезульат тестирования:\nМатематика - {2}\nФизика - {3}\nПрограмирование - {4}";
            Console.WriteLine(pattern, FullName, age, PointMath, PointPhysics, PointPrograming);
            Console.ReadKey();
        }
    }
}
