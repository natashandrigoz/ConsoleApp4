using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Найти s=max(a, b) + max(c, d)
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
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d= ");
            double d = Convert.ToDouble(Console.ReadLine());
            double s = Max(a, b) + Max(c, d);
            Console.WriteLine($"max({a},{b})+max({c},{d})={s}");
            Console.Read();
        }
    }
}
