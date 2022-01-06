using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            double K, B;
            Console.WriteLine("Вас приветствует МаРЛиН");
            Console.WriteLine("(межгалактический решатель линейных уравнений типа 0=k*x+b)");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Введите значение коэффициента k:"); 
                K = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Введите значение коэффициента b:");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода коэффициента(ов)!");
                Console.ReadKey();
                return;
            }
            LinearEquation LE = new LinearEquation(K,B);
            Console.WriteLine("РЕШЕНИЕ:"); 
            Console.WriteLine(LE.Root()); 
            Console.ReadKey();
        }
        struct LinearEquation // 0=k*x+b
        {
            double k;
            double b;

            public LinearEquation(double k, double b)
            {
                this.k = k;
                this.b = b;
            }
            public string Root()
            {
                if (k == 0 && b == 0)
                    return "Ответ: х - любое число.";
                else
                {
                    if (k == 0)
                        return "Ответ: решение не существует.";
                    else
                    {
                        double x = -b / k;
                        return $"Ответ: x = {x}";
                    }
                }
            }
        
        }
    }
}
