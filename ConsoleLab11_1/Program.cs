using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "k";
            double kf = input(f);
            f = "b";
            double bf = input(f);
            Result result = new Result { k = kf, b = bf };
            result.Root();
            Console.WriteLine();
            Console.ReadKey();
        }

        static double input(string f)
        {
            double N = 0;
            Console.Write("Введите значение коэффициента {0} = ", f);
            try
            {
                N = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                N = input(f);
            }
            return N;
        }

        struct Result
        {
            public double k;
            public double b;

            public void Root()
            {
                double x = 0;
                if (k == 0)
                {
                    if (b==0)
                    {
                        Console.WriteLine("x = любое число");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Деление на 0! Нет решений!");
                    }
                }
                if (k!=0)
                {
                    x = -(b / k);
                    Console.WriteLine("x = {0}", x);
                }
            }
        }
    }
}
