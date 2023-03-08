using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Найти наибольшее значение из трех чисел a, b, c
    /// </summary>
    internal class Program
    {
        ///<summary>
        ///Доп. метод нахождения максимальной величины
        ///</summary>
        static double Max(double x, double y)
        {
            return (x > y) ? x : y;
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
            Console.Write("z= ");
            double z = Convert.ToDouble(Console.ReadLine());
            double max = Max(Max(x, y),z);
            Console.WriteLine($"max= {max}");
            Console.Read();
        }
    }
}
