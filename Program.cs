using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        //Пример 1. Создание простого метода и его вызов
        //static void Main(string[] args)
        //{
        //    SayHello();
        //    SayGoodbye();
        //    Console.Read();
        //}
        //static void SayHello()
        //{
        //    Console.WriteLine("Hello!");
        //}
        //static void SayGoodbye()
        //{
        //    Console.WriteLine("GoodBye!");
        //}
        //Пример 2. Вызов пустого метода без возвращения значений
        /// <summary>
        /// Дополнительный метод Func()
        /// </summary>
        static void Func()
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            double f = Math.Pow(x, 2);
            Console.WriteLine($"f({x})= {f}");
        }
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main()
        {
            //Вызов метода Func() n раз
            Console.Write("n= ");
            byte n = byte.Parse(Console.ReadLine());
            for (byte i=1;i<=n;i++)
            {
                Func(); // вызов метода Func
            }
            Console.Read();
        }
    }

}
