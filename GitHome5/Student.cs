using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GitHome5
{
    /// <summary>
    ///поля Id, Name, Age, Group, MathMark (Оценка по математике от 1 до 10 включительно),
    /// PhysicalEducationMark (Оценка по физкультуре от 1 до 10),
    /// BiologyMark (Оценка по биологии от 1 до 10),
    /// Reward (денежное вознаграждение за хорошую учебу)
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Group { get; set; }

        public int MathMark { get; set; }

        public int PhysicalEducationMark { get; set; }

        public int BiologyMark { get; set; }

        public int Reward { get; set; }

        public Student(int id, string name, int age, string group, int mathMark, int physicalEducationMark, int biologyMark, int reward)
        {
            Id = id;
            Name = name;
            Age = age;
            Group = group;
            MathMark = mathMark;
            PhysicalEducationMark = physicalEducationMark;
            BiologyMark = biologyMark;
            Reward = reward;
        }             

        ///<summary>
        /// Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике. 
        /// Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них. (ex: Anton, Math mark: 10)
        /// </summary>
        public void ShowBestMarkStudent(Student[] arrayOfStudents)
        {
            int max=0;
            string name = " ";

            for (int i = 1; i < arrayOfStudents.Length; i++)
            {
                //average += matrix[i];
                if (arrayOfStudents[i].MathMark > max && arrayOfStudents[i].MathMark != max)
                {
                    max = arrayOfStudents[i].MathMark;
                    name= arrayOfStudents[i].Name;
                }
            }
            Console.WriteLine(name + ": "+max);
        }
    }
}
