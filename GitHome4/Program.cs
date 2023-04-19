using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }

        /// <summary>
        /// 1. Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'. 
        /// </summary>
        private static void Task1()
        {
            string numbersAndTest = "test14124 99lkss rwtestj 400id test  ";
            Console.WriteLine(numbersAndTest.Replace("test", "testing"));
        }

        /// <summary>
        /// 2. Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        private static void Task2()
        {
            string strWelcome = "Welcome", strTo = "to", strThe = "the", strTMS = "TMS", strLessons = "lessons";
            string[] strAll = new[] { strWelcome, strTo, strThe, strTMS, strLessons };
            string[] strResult = new string[strAll.Length];

            for (int i = 0; i < strAll.Length; i++)
            {
                strResult[i] = string.Concat("\"", strAll[i], "\"");
            }
            Console.WriteLine(string.Join(" ", strResult));
        }

        /// <summary>
        /// 3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
        /// Результат вывести в консоль.
        /// </summary>
        private static void Task3()
        {
            string strTotal = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string exclude = "abc";

            int index = strTotal.IndexOf(exclude);

            string firstPart = strTotal.Substring(0, index);
            string secondPart = strTotal.Substring(index + exclude.Length);

            Console.WriteLine($"{nameof(firstPart)}: {firstPart}");
            Console.WriteLine($"{nameof(secondPart)}: {secondPart}");

            //another variant for fun
            string[] str = strTotal.Split(exclude);

            Console.WriteLine("\n\ranother variant");
            Console.WriteLine("firstPart: " + str[0]);
            Console.WriteLine("secondPart: " + str[1]);
        }

        /// <summary>
        /// 4. Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good". После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        private static void Task4()
        {
            string strGoodDay = "Good day";

            string strDay = strGoodDay.Substring("Good".Length);
            string strBestDay = strDay.Insert(0, "The best").Insert(strDay.Length + "The best".Length, "!!!!!!!!!");
            string strResult = strBestDay.Remove(strBestDay.LastIndexOf('!')).Insert(strBestDay.LastIndexOf('!'), "?");

            Console.WriteLine(strResult);
        }

        /// <summary>
        /// 5. Введите с консоли строку, которая будет содержать буквы и цифры.Удалите из исходной строки все цифры и выведите их на экран.
        /// (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        private static void Task5()
        {
            string? strInput;

            Console.WriteLine("Please enter a sentence");
            if (string.IsNullOrWhiteSpace(strInput = Console.ReadLine()))
            {
                Console.WriteLine("Empty string entered, please enter a sentence");
                return;
            }

            char[] charInputArray = strInput.ToCharArray();

            Console.WriteLine("\n\r\n\rNumber:");
            for (int i = 0; i < charInputArray.Length; i++)
            {
                if (char.IsDigit(charInputArray[i]))
                {
                    Console.Write(charInputArray[i]);
                    strInput = strInput.Replace(Convert.ToString(charInputArray[i]), "");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n\r" + (string.IsNullOrEmpty(strInput) ? " " : "strOutput: " + strInput));
        }

        /// <summary>
        /// 6. Задайте 2 предложения из консоли.Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        private static void Task6()
        {
            string firstSentence, secondSentence;
            int i = 0;

            Console.WriteLine("Please enter a first sentence");
            if (string.IsNullOrWhiteSpace(firstSentence = Console.ReadLine()))
            {
                Console.WriteLine("Empty string entered, please enter a sentence");
                return;
            }

            Console.WriteLine("Please enter a second sentence");
            if (string.IsNullOrWhiteSpace(secondSentence = Console.ReadLine()))
            {
                Console.WriteLine("Empty string entered, please enter a sentence");
                return;
            }

            string[] firstSentenceArray = firstSentence.ToLower().Split(" ");
            string[] secondSentenceArray = secondSentence.ToLower().Split(" ");

            String s = String.Format("{0,-15} {1,-10}\n\n", "Word", "Occurs");

            foreach (string word in firstSentenceArray)
            {
                foreach (string word2 in secondSentenceArray)
                {
                    if (word.Equals(word2) && !string.IsNullOrWhiteSpace(word))
                    {
                        i++;
                    }
                }
                s += String.Format("{0,-15} {1,-10:N0}\n", word, i);
                i = 0;
            }
            Console.WriteLine($"\n{s}");
        }
    }
}