using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWork_02._10._21
{
    class Program
    {
        static void SolveEqation(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("x = {0}", (double)((-1) * c / b));
            }
            else
            {
                double discriminant = b * b - 4 * a * c;
                if (discriminant < 0)
                {
                    Console.WriteLine("Корней нет");
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("х = {0}", (double)((-1) * b / (2 * a)));
                }
                else
                {
                    Console.WriteLine("x1 = {0}\nx2 = {1}", (double)((-1) * b + Math.Sqrt(discriminant)) / (2 * a), (double)((-1) * b - Math.Sqrt(discriminant)) / (2 * a));
                }
            }
        }
        static int Method(ref long multiplication, out double average, params int[] array)
        {
            multiplication = 1;
            for (int i = 0; i < array.Length; i++)
            {
                multiplication *= array[i];
            }
            average = array.Average();
            return array.Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1. Решение квадратного уравнения\nВведите а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            SolveEqation(a, b, c);

            Console.WriteLine("Task 2. Меняем два элемента массива местами\nДан массив: ");
            Random r = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1000);
                Console.Write("{0}: {1}; ", i + 1, array[i]);
            }
            Console.WriteLine("\nВведите первый индекс элемента, который нужно поменять");
            byte index_one = byte.Parse(Console.ReadLine());
            if (index_one <= 0 | index_one > 19)
            {
                Console.WriteLine("Выход за границы массива, первый индекс будет равен 1 теперь");
                index_one = 1;
            }
            Console.WriteLine("Введите второй элемента, который нужно поменять");
            byte index_two = byte.Parse(Console.ReadLine());
            if (index_two <= 0 | index_two > 19)
            {
                Console.WriteLine("Выход за границы массива, второй индекс будет равен 1 теперь");
                index_two = 1;
            }
            int temp = array[index_one - 1];
            array[index_one - 1] = array[index_two - 1];
            array[index_two - 1] = temp;
            Console.WriteLine("Получившийся массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}: {1}; ", i + 1, array[i]);
            }

            Console.WriteLine("\nTask 3. Cортировка массива из задания 2 пузырьком");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Получившийся массив");
            Console.WriteLine(String.Join(", ", array));

            Console.WriteLine("Task 4\nДан массив");
            long mult = 0;
            double avg;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(20);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nСумма элементов массива равна {0}\nПроизведение элементов равно равно {1}\nСреднее значение элементов массива равно {2}", Method(ref mult, out avg, array), mult, avg);

            Console.WriteLine("Task 5");
            try
            {
                while (true)
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.WriteLine("Введите число от 0 до 9. Введите 'exit' или 'закрыть', если хотите завершить работу программы");
                    string input = Console.ReadLine().ToLower();
                    if (input == "exit" | input == "закрыть")
                    {
                        Console.WriteLine("bye");
                        break;
                    }
                    byte number = byte.Parse(input);
                    if (number < 0 | number > 9)
                    {
                        Console.Clear();
                        Task.Delay(3000);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR");
                        System.Threading.Thread.Sleep(3000);                    
                    }
                    else if (number == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(" #### \n#    #\n#    #\n#    #\n ####");
                        Console.ReadKey();
                    }
                    else if (number == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("  #\n###\n  #\n  #\n####");
                        Console.ReadKey();
                    }
                    else if (number == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("#####\n    #\n ####\n#     \n#####");
                        Console.ReadKey();
                    }
                    else if (number == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("#####\n   #\n ####\n     #\n#####");
                        Console.ReadKey();
                    }
                    else if (number == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("#   #\n#   #\n#   #\n#####\n    #\n    #");
                        Console.ReadKey();
                    }
                    else if (number == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("######\n#\n#####\n     #\n     #\n#####");
                        Console.ReadKey();
                    }
                    else if (number == 6)
                    {
                        Console.Clear();
                        Console.WriteLine(" #####\n#\n #####\n#     #\n#     #\n #####");
                        Console.ReadKey();
                    }
                    else if (number == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("#####\n   #\n  #\n  #");
                        Console.ReadKey();
                    }
                    else if (number == 8)
                    {
                        Console.Clear();
                        Console.WriteLine(" ####\n#    #\n#    #\n ####\n#    #\n#    #\n ####");
                        Console.ReadKey();
                    }
                    else if (number == 9)
                    {
                        Console.Clear();
                        Console.WriteLine(" ####\n#    #\n#    #\n ####\n     #\n     #\n#####");
                        Console.ReadKey();
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не цифру");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Слишком больше число");
            }
            Console.ReadKey();
        }
    }
}
