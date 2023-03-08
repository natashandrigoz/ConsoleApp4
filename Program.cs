using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Нахождение максимальной величины из двух целых переменных a, b
    /// </summary>
    internal class Program
    {
        ///<summary>
        ///Доп. метод нахождения максимальной величины
        ///</summary>
        static double Func(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main()
        {
            Console.Write("x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y= ");
            double y = Convert.ToDouble(Console.ReadLine());
            double max=Func(x,y);
            Console.WriteLine($"max= {max}");
            Console.Read();
        }
    }
}
