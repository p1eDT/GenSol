using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome10.Linq
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

        }

        /// <summary>
        /// Напишите метод, который возвращает предоставленный список пользователей, упорядоченный по LastName в порядке убывания.
        /// </summary>
        public void ReverseOrderByLastName()
        {

        }
    }
}
