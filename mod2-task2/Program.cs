using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Николетта Фрост";
            double PointPrograming = 56.2;
            double PointMath = 26.8;
            double PointPhysics = 76.3;
            double summ = (PointPrograming + PointMath + PointPhysics)/3;

            Console.WriteLine($"Испытуемый: {FullName}\nСредняя оченка эффективности: {summ}");
            Console.WriteLine("\nДля просмотра детального отчета нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine("\nПрограммирование: {0}\nФизика: {1}\nМатематика: {2}", 
                PointPrograming, 
                PointPhysics, 
                PointMath);
            Console.ReadKey();
        }
    }
}
