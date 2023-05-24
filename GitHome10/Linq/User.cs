using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GitHome10
{
    public class User
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// Напишите метод, который возвращает "<FirstName> <MiddleName> <LastName>", если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.
        /// </summary>
        public void GetUserAfterCheckMiddleName()
        {
            if (MiddleName == "" || MiddleName==null)
            { 
                Console.WriteLine($"FirstName: {FirstName}\t LastName: {LastName}"); 
            }
            else 
            { 
                Show(); 
            }
        }

        /// <summary>
        /// Напишите метод, который возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.
        /// </summary>
        public static List<User> ReverseOrderByLastName(List<User> user)
        {
            return user.OrderBy(u=>u.LastName).Reverse().ToList();
        }

        public void Show()
        {
            Console.WriteLine($"FirstName: {FirstName}\t MiddleName: {MiddleName}\t LastName: {LastName}");
        }
    }
}
