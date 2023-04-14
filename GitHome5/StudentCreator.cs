using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome5
{
    public class StudentCreator
    {
        public Student[] CreateStudent(string groupName)
        {
            Student[] arrayOfStudents = new Student[5];
            string[] names = { "Name1", "Name2", "Name3", "Name4", "Name5", "Name6", "Name7", "Name8", "Name9", "Name10", "Name11", "Name12", "Name13", "Name14", "Name15" };
            Random random = new Random();

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int randMark1 = random.Next(1, 10);
                int randMark2 = random.Next(1, 10);
                int randMark3 = random.Next(1, 10);
                int randName = random.Next(1, 15);
                arrayOfStudents[i] = new Student(i, names[randName], 20, groupName, randMark1, randMark2, randMark3, 100);
            }
            return arrayOfStudents;
        }
    }
}
