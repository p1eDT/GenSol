using GitHome9;
using System;
using System.Reflection.Metadata.Ecma335;

namespace GitHome8 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        /// <summary>
        /// Создайте коллекцию состояющую из объектов Person (поля Name, Age, Salary)
        /// Выведите всех Person, чье имя начинается на A
        /// Выведите всех Person, у кого зп больше 1000 и возраст меньше 30. 
        /// Выведите первого человека старше 50 
        /// Добавьте свои классы исключений - SalaryException, AgeException и добавьте в поля Age и Salary проверку, 
        /// если Age меньше 18 - сгенерируйте исключение, если salary меньше 100 - сгенерируйте исключение
        /// Обработайте исключения
        /// </summary>
        static void Main(string[] args)
        {
            string[] names = { "Alex", "Fedya", "Roman", "Nikita", "Mary", "Anna", "Ekaterina", "Seb", "Artem" };
            int[] age = { 30, 22, 57, 33, 23, 44, 171, 18, 19 };
            int[] salary = { 110, 220, 570, 330, 2300, 430, 1700, 180, 190 };

            List<Person> persons = new List<Person>(Person.Create(names, age, salary));  // Обработайте исключения

            Person.PersonsStartsWith(persons);             // Выведите всех Person, чье имя начинается на A
            Person.PersonsByAgeAndSalary(persons);         // Выведите всех Person, у кого зп больше 1000 и возраст меньше 30
            Person.FirstPersonOlder(persons);              // Выведите первого человека старше 50
            
            Console.WriteLine();
        }
    }
}