using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        public static double Enter()
        {
            double a;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Повторите ввод double числа ");
                a = Enter();
            }
            return a;
        }
        public static void reshenie()
        {
            double a, b, c, D, x1, x2;
            Console.WriteLine("Введите a: ");
            a = Enter();
            Console.WriteLine("Введите b: ");
            b = Enter();
            Console.WriteLine("Введите c: ");
            c = Enter();
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(D.ToString(), "/n");
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\nx2= {1}", x1, x2);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Дискриминанта нет");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            reshenie();
        }


    }
}
