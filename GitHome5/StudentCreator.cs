using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome5
{
    public class StudentCreator
    {
        public Student[] CreateStudent()
        {
            Student[] arrayOfStudents = new Student[15];
            string[] names = { "Name1", "Name2", "Name3", "Name4", "Name5", "Name6", "Name7", "Name8", "Name9", "Name10", "Name11", "Name12", "Name13", "Name14", "Name15" };
            Random random = new Random();
            int id = 1;

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int randMark1 = random.Next(1, 10);
                int randMark2 = random.Next(1, 10);
                int randMark3 = random.Next(1, 10);
                int randName = random.Next(0, 14);
                arrayOfStudents[i] = new Student(id++, names[randName], 20, randMark1, randMark2, randMark3, 0);
            }
            return arrayOfStudents;
        }
    }
}