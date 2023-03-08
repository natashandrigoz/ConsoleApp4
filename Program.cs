using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Найти периметр и площадь треугольника, заданного координатами своих вершин. 
    /// Определить метод для расчета длины отрезка по координатам его вершин
    /// </summary>
    internal class Program
    {
        ///<summary>
        ///Доп. метод для расчета длины отрезка по координатам его вершин
        ///</summary>
        static double Dlina(double x1, double y1,double x2,double y2)
        {
            return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
        }
        ///<summary>
        ///Доп. метод для расчета периметра треугольника, 
        ///заданного координатами своих вершин
        ///</summary>
        static double Perimetr(double a,double b, double c)
        {
            return a + b + c;
        }
        ///<summary>
        ///Доп. метод для расчета площади треугольника, 
        ///заданного координатами своих вершин
        ///</summary>
        static double Square(double a, double b, double c)
        {
            double pp = (a + b + c) / 2;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Введите координаты первой вершины:");
            Console.Write("x1= ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1= ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины:");
            Console.Write("x2= ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2= ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины:");
            Console.Write("x3= ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3= ");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр треугольника, заданного координатами своих вершин, = " +
                $"{Perimetr(Dlina(x1,y1,x2,y2),Dlina(x2,y2,x3,y3),Dlina(x1,y1,x3,y3)):f2}");
            Console.WriteLine($"Площадь треугольника, заданного координатами своих вершин, = " +
                $"{Square(Dlina(x1, y1, x2, y2), Dlina(x2, y2, x3, y3), Dlina(x1, y1, x3, y3)):f2}");
            Console.Read();
        }
    }
}
