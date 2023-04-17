using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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

        public int MathMark { get; set; }

        public int PhysicalEducationMark { get; set; }

        public int BiologyMark { get; set; }

        public int Reward { get; set; }

        public Student(int id, string name, int age, int mathMark, int physicalEducationMark, int biologyMark, int reward)
        {
            Id = id;
            Name = name;
            Age = age;
            MathMark = mathMark;
            PhysicalEducationMark = physicalEducationMark;
            BiologyMark = biologyMark;
            Reward = reward;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Id: " + Id + " Name: " + Name + " Group: " + " BiologyMark: " + BiologyMark + " MathMark: " + MathMark 
                + " PhysicalEducationMark: " + PhysicalEducationMark + " Reward: " + Reward);
        }

        ///<summary>
        /// Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике. 
        /// Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них. (ex: Anton, Math mark: 10)
        /// </summary>
        public void ShowBestMathMark(Student[] arrayOfStudents, out int Id)
        {
            Id = 0;
            int max = 0;
            string name = " ";

            for (int i = 1; i < arrayOfStudents.Length; i++)
            {
                if (arrayOfStudents[i].MathMark > max && arrayOfStudents[i].MathMark != max)
                {
                    max = arrayOfStudents[i].MathMark;
                    name = arrayOfStudents[i].Name;
                    Id = arrayOfStudents[i].Id;
                }
            }
            Console.WriteLine("Student: " + name + " MathMark: " + max);
        }

        /// <summary>
        /// Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Физкультуре. 
        /// Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
        /// </summary>
        public void ShowBestPhysicalEducationMark(Student[] arrayOfStudents, out int Id)
        {
            Id = 0;
            int max = 0;
            string name = " ";

            for (int i = 1; i < arrayOfStudents.Length; i++)
            {
                if (arrayOfStudents[i].PhysicalEducationMark > max && arrayOfStudents[i].PhysicalEducationMark != max)
                {
                    max = arrayOfStudents[i].PhysicalEducationMark;
                    name = arrayOfStudents[i].Name;
                    Id = arrayOfStudents[i].Id;
                }
            }
            Console.WriteLine("Student: " + name + " PhysicalEducationMark: " + max);
        }

        /// <summary>
        /// Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Биологии. 
        /// Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
        /// </summary>
        public void ShowBestBiologyMark(Student[] arrayOfStudents, out int Id)
        {
            Id = 0;
            int max = 0;
            string name = " ";

            for (int i = 1; i < arrayOfStudents.Length; i++)
            {
                if (arrayOfStudents[i].BiologyMark > max && arrayOfStudents[i].BiologyMark != max)
                {
                    max = arrayOfStudents[i].BiologyMark;
                    name = arrayOfStudents[i].Name;
                    Id = arrayOfStudents[i].Id;
                }
            }
            Console.WriteLine("Student: " + name + " BiologyMark: " + max);
        }

        public int[] GetIds(Student[] arrayOfStudents)
        {
            ShowBestBiologyMark(arrayOfStudents, out int id1);
            ShowBestPhysicalEducationMark(arrayOfStudents, out int id2);
            ShowBestMathMark(arrayOfStudents, out int id3);
            int[] ids= {id1,id2,id3};
            return ids;
        }

        public void SetReward(int id)
        {
            Random random = new Random();
            int rndReward = random.Next(1, 100);

            if (id == Id)
            {
                Reward = rndReward;
            }
        }
    }
}