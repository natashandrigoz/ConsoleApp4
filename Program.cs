using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        ///<summary>
        ///Доп. метод нахождения суммы двух чисел
        ///</summary>
        static double Func(double x, double y)
        {
            return x+y;
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
            double z=Func(x,y);
            Console.WriteLine($"z= {z}");
            Console.Read();
        }
    }
}
