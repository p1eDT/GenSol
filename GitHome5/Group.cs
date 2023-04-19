using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome5
{
    internal class Group
    {
        Student[] Students { get; set; }

        public string GroupName { get; set; }

        public Group(Student[] students, string groupName)
        {
            Students = students;
            GroupName = groupName;
        }

        public void ShowInfo()
        {
            Console.WriteLine(GroupName);
            foreach (Student student in Students)
            {
                student.ShowInfo();
            }
        }

        public void ShowBestMathMark()
        {
            Students[0].ShowBestMathMark(Students, out int id);
        }

        public void ShowBestPhysicalEducationMark()
        {
            Students[0].ShowBestPhysicalEducationMark(Students, out int id);
        }

        public void ShowBestBiologyMark()
        {
            Students[0].ShowBestBiologyMark(Students, out int id);
        }

        public void SetReward()
        {
            int[] ids = Students[0].GetIds(Students);
            foreach (int id in ids)
            {
                foreach (Student student in Students)
                {
                    student.SetReward(id);
                }
            }
        }
    }
}