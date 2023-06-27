using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsArrayMember();
            ExcludeNumberFromArray();
            Task2();
            Task3();
            Task4();
            Task5();
            //Task6(); not ready
            SumArray();
            Task8();
            Task9();
        }

        public static void IsArrayMember()
        {
            //0.Создайте массив целых чисел.
            //Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
            //Пусть число для поиска задается с консоли.

            Random rnd = new Random();
            int[] matrix = new int[3];
            bool isMember = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = (int)rnd.NextInt64(0, 9);
                Console.Write(matrix[i] + " ");
            }

            Console.WriteLine("Enter number");
            if (!(int.TryParse(Console.ReadLine(), out int userInt)))
            {
                Console.WriteLine("Please use only integer");
                return;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] == userInt)
                {
                    isMember = true;
                }
            }
            Console.WriteLine("Your number " + userInt + " is " + ((isMember) ? "" : "not ") + "in the array");
        }

        public static void ExcludeNumberFromArray()
        {
            //1.Создайте массив целых чисел.Удалите все вхождения заданного числа из массива.
            //Пусть число задается с консоли.Если такого числа нет -выведите сообщения об этом.
            //В результате должен быть новый массив без указанного числа.
            Random rnd = new Random();
            int[] matrix = new int[3];
            bool isMember = false;

            Console.WriteLine("Start array: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = (int)rnd.NextInt64(0, 9);
                Console.Write(matrix[i] + " ");
            }

            Console.WriteLine("\r\n\r\nEnter a number to exclude");
            if (!(int.TryParse(Console.ReadLine(), out int userInt)))
            {
                Console.WriteLine("Please use only integer");
                return;
            }

            Console.WriteLine("\r\nFinish array:");
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] == userInt)
                {
                    matrix[i]++;
                    isMember = true;
                }

                Console.Write(matrix[i] + " ");
            }
            Console.WriteLine((isMember) ? "" : "\r\n\r\nYour number in not in the array");
        }

        public static void Task2()
        {
            //2.Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
            //Для генерации случайного числа используйте метод Random().Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.  
            Console.WriteLine("Enter the size of the array");
            if (!(uint.TryParse(Console.ReadLine(), out uint size)) || size == 0)
            {
                Console.WriteLine("Please use only integers greater than zero");
                return;
            }

            Random rnd = new Random();
            int[] matrix = new int[size];

            Console.WriteLine("\r\nArray: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = (int)rnd.NextInt64(-9, 9);
                Console.Write(matrix[i] + " ");
            }

            int max, min;
            max = min = matrix[0];
            double average = matrix[0];

            for (int i = 1; i < matrix.Length; i++)
            {
                average += matrix[i];
                if (matrix[i] > max && matrix[i] != max)
                {
                    max = matrix[i];
                }
                else
                {
                    min = matrix[i];
                }
            }

            Console.WriteLine("\r\n\r\nMax: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Average: " + (average / size));

        }

        public static void Task3()
        {
            //3.Создайте 2 массива из 5 чисел. Выведите массивы на консоль в двух отдельных строках.  
            //Посчитайте среднее арифметическое элементов каждого массива и сообщите,
            //для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
            Random rnd = new Random();
            int[] matrix1 = new int[5];
            int[] matrix2 = new int[5];
            double average1 = matrix1[0];
            double average2 = matrix2[0];

            Console.WriteLine("Array1: ");
            for (int i = 0; i < 5; i++)
            {
                matrix1[i] = (int)rnd.NextInt64(-9, 9);
                matrix2[i] = (int)rnd.NextInt64(-9, 9);
                Console.Write(matrix1[i] + " ");
            }

            Console.WriteLine("\n\r\n\rArray2: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matrix2[i] + " ");
                average1 += matrix1[i];
                average2 += matrix2[i];
            }

            if (average1 > average2)
            {
                Console.WriteLine("\n\r\n\rAverage " + (average1 / 5) + " of Array1 is greater");
            }
            else if (average1 < average2)
            {
                Console.WriteLine("\n\r\n\rAverage " + (average2 / 5) + " of Array2 is greater");
            }
            else
            {
                Console.WriteLine("\n\r\n\rAverage of Arrays is equal");
            }
        }

        public static void Task4()
        {
            //4.Создайте массив и заполните массив.  
            //Выведите массив на экран в строку.  
            //Замените каждый элемент с нечётным индексом на ноль.  
            //Снова выведете массив на экран на отдельной строке. 

            Console.WriteLine("Enter the size of the array");
            if (!(uint.TryParse(Console.ReadLine(), out uint size)) || size == 0)
            {
                Console.WriteLine("Please use only integers greater than zero");
                return;
            }

            Random rnd = new Random();
            int[] matrix = new int[size];

            Console.WriteLine("\r\nStart array: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = (int)rnd.NextInt64(1, 9);
                Console.Write(matrix[i] + " ");
            }

            Console.WriteLine("\r\nFinish array: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i % 2 != 0)
                {
                    matrix[i] = 0;
                }
                Console.Write(matrix[i] + " ");
            }
        }

        public static void Task5()
        {
            //5.Создайте массив строк. Заполните его произвольными именами людей.
            //Отсортируйте массив.  
            //Результат выведите на консоль.

        }

        public static void Task6()
        {
            //6.Реализуйте алгоритм сортировки массива пузырьком.
            Random rnd = new Random();
            int[] matrix = new int[6];

            Console.WriteLine("\r\nStart array: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = (int)rnd.NextInt64(1, 9);
                Console.Write(matrix[i] + " ");
            }

            for (int j = 0; j < matrix.Length - 1; j++)
            {
                bool isEnd = true;

                for (int i = 0; i < matrix.Length - 1; i++)
                {
                    if (matrix[i] > matrix[i + 1])
                    {
                        matrix[i] += matrix[i + 1];
                        matrix[i + 1] = matrix[i] - matrix[i + 1];
                        matrix[i] -= matrix[i + 1];

                        isEnd = false;
                    }
                }
                if (isEnd)
                {
                    break;
                }
            }

            Console.WriteLine("\r\nFinish array: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[i] + " ");
            }
        }

        public static void SumArray()
        {
            //7.Создайте двумерный массив целых чисел.Выведите на консоль сумму всех элементов массива.
            Random rnd = new Random();
            int[,] matrix = new int[4, 4];
            int sum = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 12);
                    Console.Write(matrix[i, j] + " ");

                    sum += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of all array numbers = " + sum);
        }

        public static void Task8()
        {
            //Создайте двумерный массив.Выведите на консоль диагонали массива.
            Random rnd = new Random();
            int[,] matrix = new int[4, 4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 99);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\rMain diagonal: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, i] + " ");
            }

            Console.WriteLine("\n\rSecondary diagonal: ");
            for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
            {
                Console.WriteLine(matrix[i, matrix.GetLength(0) - 1 - i] + " "); ;
            }
        }

        public static void Task9()
        {
            //Дополнительное задание  
            //9. Создайте массив из n случайных целых чисел и выведите его на экран.
            //Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.  
            //Если n не удовлетворяет условию - выведите сообщение об этом.  Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
            //Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
            Random rnd = new Random();
            bool badNumber = false;
            uint size;

            do
            {
                Console.WriteLine("Enter the size of the array");
                if (!(uint.TryParse(Console.ReadLine(), out size)) || size <= 5 || size > 10)
                {
                    Console.WriteLine("Please use only integers 6 to 10");
                    badNumber = true;
                }
                else
                {
                    badNumber = false;
                }
            }
            while (badNumber);

            int[] matrix = new int[size];
            int[] matrixEven = { };
            int j = 0;

            Console.WriteLine("\r\nStart array: ");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = (int)rnd.NextInt64(0, 9);
                Console.Write(matrix[i] + " ");
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] % 2 == 0)
                {
                    Array.Resize(ref matrixEven, j + 1);
                    matrixEven[j] = (int)matrix[i];
                    j++;
                }
            }

            if (j > 0)
            {
                Console.WriteLine("\r\n\r\nArray of even numbers: ");
                for (int i = 0; i < matrixEven.Length; i++)
                {
                    Console.Write(matrixEven[i] + " ");
                }
            }
        }
    }
}