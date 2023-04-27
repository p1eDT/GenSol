using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GitHome9
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new AgeException("Age is to young: ", value);
                }
                else
                {
                    age = value;
                }
            }
        }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 100)
                {
                    throw new SalaryException("Too little money", value);
                }
                else
                {
                    salary = value;
                }
            }
        }

        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void ShowPersonName(bool isLine = true)
        {
            if (isLine)
            {
                Console.WriteLine($"Name: {Name}");
            }
            else
            {
                Console.Write($"Name: {Name}");
            }
        }

        public void ShowPersonAge(bool isLine = true)
        {
            if (isLine)
            {
                Console.WriteLine($"Age: {Age}");
            }
            else
            {
                Console.Write($"\t Age: {Age}");
            }
        }

        public void ShowPersonSalary(bool isLine = true)
        {
            if (isLine)
            {
                Console.WriteLine($"Salary: {Salary}");
            }
            else
            {
                Console.Write($"\t Salary: {Salary}");
            }
        }

        private static Person[] CreatePersons(string[] names, int[] age, int[] salary)
        {
            Person[] persons = new Person[names.Length];

            if (names.Length == age.Length && names.Length == salary.Length)
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    persons[i] = new Person(names[i], age[i], salary[i]);
                }
            }
            else
            {
                throw new Exception($"Count of arrays not equal: \n\r" +
                    $"names:    \t{names.Length} \n\r" +
                    $"age:    \t{age.Length} \n\r" +
                    $"salary:   \t{salary.Length}\n\r");
            }
            return persons;
        }

        public static Person[] Create(string[] names, int[] age, int[] salary)
        {
            Person[] persons = Array.Empty<Person>();
            try
            {
                persons = Person.CreatePersons(names, age, salary);
            }
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message + " stack " + ae.StackTrace);
                ae.InfoMessage();
            }
            catch (SalaryException se)
            {
                Console.WriteLine(se.Message + " stack " + se.StackTrace);
                se.InfoMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not correct information " + ex.Message + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("End of CreatePersons ");
                foreach (Person person in persons)
                {
                    person.ShowPersonName(false);
                    person.ShowPersonAge(false);
                    person.ShowPersonSalary(false);
                    Console.WriteLine();
                }
            }
            return persons;
        }

        /// <summary>
        /// Выведите всех Person, чье имя начинается на Char
        /// </summary>
        /// <param name="persons">List<Person> persons</param>
        /// <param name="startsWith">char</param>
        public static void PersonsStartsWith(List<Person> persons, char startsWith = 'A')
        {
            var personsStartsWith = from person in persons
                                    where person.Name.StartsWith(startsWith)
                                    select person;

            Console.WriteLine($"\n\rPersons starts with {startsWith}: ");
            foreach (var person in personsStartsWith)
            {
                person.ShowPersonName();
            }
        }

        public static void PersonsByAgeAndSalary(List<Person> persons, int maxAge = 31, int MinSalary = 999)
        {
            var personsByAgeAndSalary = from person in persons
                                        where person.Salary > MinSalary
                                        where person.Age < maxAge
                                        select person;

            Console.WriteLine($"\n\rPersons who has a salary of more than {MinSalary + 1} and an age of less than {maxAge - 1}: ");
            foreach (var person in personsByAgeAndSalary)
            {
                person.ShowPersonName(false);
                person.ShowPersonAge(false);
                person.ShowPersonSalary(false);
            }
        }

        public static void FirstPersonOlder(List<Person> persons, int age = 50)
        {
            var firstPersonOlder = persons.First(pers => pers.Age > age);

            Console.WriteLine($"\n\rFirst person over {age}: ");

            firstPersonOlder.ShowPersonName(false);
            firstPersonOlder.ShowPersonAge(false);
        }
    }
}