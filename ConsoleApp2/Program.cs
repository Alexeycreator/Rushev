using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание.");
            Console.WriteLine("1 - радиус окружности, площадь круга которой равна s;");
            Console.WriteLine("2 - какая из цифр трехзначного числа больше: первая или вторая");
            int chek = Convert.ToInt32(Console.ReadLine());
            switch (chek)
            {
                case 1: { firstprogramm();break; }
                case 2: { secondprogramm();break; }
            }
            Console.ReadKey();
        }
        static void firstprogramm()
        {
            Console.Write("s= ");
            double s = Convert.ToDouble(Console.ReadLine());
            double radius = Math.Sqrt(s / Math.PI);
            Console.WriteLine("r= Радиус окружности, длина которой равна единице составляет: {0:N4}", radius);
            Console.WriteLine("Для продолжения нажмите на любую клавишу . . . ");
        }
        static void secondprogramm()
        {
            Console.WriteLine("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a < 1000)
            {
                int first = a / 100;
                int last = a % 10;
                if (first > last)
                    Console.WriteLine("Первое больше ");
                if (first < last)
                    Console.WriteLine("Последнее больше");
                if (first == last)
                    Console.WriteLine("Числа равны");
            }
        }
    }
}
