namespace GitHome1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        public static void Task1()
        {
            Console.WriteLine("Enter first number");
            if (!(Decimal.TryParse(Console.ReadLine(), out Decimal operand1)))
            {
                Console.WriteLine("Please use only numbers");
                return;
            }

            Console.WriteLine("Enter second number");
            if (!(Decimal.TryParse(Console.ReadLine(), out Decimal operand2)))
            {
                Console.WriteLine("Please use only numbers");
                return;
            }

            Console.WriteLine("Enter arithmetic operation");
            string sign = Convert.ToString(Console.ReadKey().KeyChar);

            Decimal result = 0;

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/" when operand2 == 0 && operand1 != 0:
                    Console.WriteLine("Can't divide by zero");
                    return;
                case "/":
                    result = operand1 / operand2;
                    break;
                default:
                    Console.WriteLine("\r\nPlease use only arithmetic operations");
                    return;
            }

            Console.WriteLine("\r\nresult: " + result);
        }

        public static void Task2()
        {
            Console.WriteLine("Enter integer");
            if (!(int.TryParse(Console.ReadLine(), out int userNum)))
            {
                Console.WriteLine("Please use only integer");
                return;
            }

            string result = "your number is not included in any of the available number ranges";
            switch (userNum)
            {
                case > 0 and <= 14:
                    result = "Your number is between 0-14";
                    break;
                case >= 15 and <= 35:
                    result = "Your number is between 15-35";
                    break;
                case >= 36 and <= 50:
                    result = "Your number is between 36-50";
                    break;
                case >= 51 and <= 100:
                    result = "Your number is between 51-100";
                    break;
            }
            Console.WriteLine(result);
        }

        public static void Task3()
        {
            Console.WriteLine("Введите слово о погоде на русском языке: ");
            string wordRu = Console.ReadLine();
            if (!Regex.IsMatch((wordRu), "^[а-яА-я]*$"))
            {
                Console.WriteLine("Пожалуйста, используйте только кириллицу");
                return;
            }

            string wordEn = "Перевод: ";

            switch (wordRu)
            {
                case "Солнце": wordEn += "Sun"; break;
                case "Шторм": wordEn += "Storm"; break;
                case "Дождь": wordEn += "Rain"; break;
                case "Ветер": wordEn += "Wind"; break;
                case "Гроза": wordEn += "Thunderstorm"; break;
                case "Радуга": wordEn += "Rainbow"; break;
                case "Иней": wordEn += "Hoarfrost"; break;
                case "Сосулька": wordEn += "Icicle"; break;
                case "Метель": wordEn += "Blizzard"; break;
                case "Небо": wordEn += "Sky"; break;
                default: wordEn = "Введенного слова нет в словаре"; break;
            }
            Console.WriteLine(wordEn);
        }

        public static void Task4()
        {
            Console.WriteLine("Enter integer");
            if (!(int.TryParse(Console.ReadLine(), out int userNumber)))
            {
                Console.WriteLine("Please use only integer");
                return;
            }
            Console.WriteLine("Your number " + userNumber + " is " + ((userNumber % 2 != 0) ? "un" : "") + "even");
        }
    }
}