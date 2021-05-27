using System;
/*Задание 2 
Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. 
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, 
среднее арифметическое всех элементов, вывести все нечетные значения. */
namespace Lesson5_taks2
{

    class Program
    {
        public static int ArrayMin(Array x)
        {
            int min = 99999;
            foreach (int number in x)
            {
                min = min < number ? min : number;
            }
            return min;
        }
        public static int ArrayMax(Array x)
        {
            int max = 0;
            foreach (int number in x)
            {
                max = max > number ? max : number;
            }
            return max;
        }
        public static int ArraySum(Array x)
        {
            int sum = 0;
            foreach (int number in x)
            {
                sum += number;
            }
            return sum;
        }
        public static int ArrayAverage(Array x)
        {
            int result = ArraySum(x) / x.Length;
            return result;
        }
        public static void ArrayEven(Array x)
        {
            Console.Write("Even:\t");
            foreach (int number in x)
            {
                string i = number % 2 == 0 ? $"{number}," : "";
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input Lenght of Array");
                bool inti = int.TryParse(Console.ReadLine(), out int n);
                if (inti)
                {
                    int [] array = new int[n];
                    for (int i = 0; i < array.Length; i++)
                    {
                        Random rnd = new Random();
                        array[i] = rnd.Next(0,999);
                        Console.WriteLine(array[i]);
                    }
                    Console.WriteLine("Minimum: {0}", ArrayMin(array));
                    Console.WriteLine("Maximum: {0}", ArrayMax(array));
                    Console.WriteLine("Sum: {0}", ArraySum(array));
                    Console.WriteLine("Average: {0}", ArrayAverage(array));
                    ArrayEven(array);
                    Console.WriteLine(new string('-', 25));
                }
            }

        }
    }
}
