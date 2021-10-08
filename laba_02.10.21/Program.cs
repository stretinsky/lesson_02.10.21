using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_02._10._21
{
    class Program
    {
        static double Max(double numberOne, double numberTwo)
        {
            if (numberOne >= numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }
        }
        static void Swap(ref string lineOne, ref string lineTwo)
        {
            string temp = lineOne;
            lineOne = lineTwo;
            lineTwo = temp;
        }
        static bool Fact(int number, out long result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i < number; i++)
                    {
                        result *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
            return true;
        }
        static long RecursFact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return n * RecursFact(n - 1);
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1. Введите первое число");
            double numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Большее из них {0}", Max(numberOne, numberTwo));

            Console.WriteLine("Упражнение 5.2. Введите первый параметр");
            string lineOne = Console.ReadLine();
            Console.WriteLine("Введите второй параметр");
            string lineTwo = Console.ReadLine();
            Swap(ref lineOne, ref lineTwo);
            Console.WriteLine("Теперь первый параметр это '{0}', а второй это '{1}'", lineOne, lineTwo);

            Console.WriteLine("Упражнение 5.3. Введите число");
            int input = int.Parse(Console.ReadLine());
            long result;
            Console.WriteLine(Fact(input, out result));
            Console.WriteLine("Его факториал равен {0}", result);

            Console.WriteLine("Упражнение 5.4. Введите число");
            Console.WriteLine("Его факториал равен {0}", RecursFact(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
