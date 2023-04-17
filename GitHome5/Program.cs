using System;

namespace GitHome5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCreator studentCreator = new StudentCreator();
            Student[] students = studentCreator.CreateStudent();
            Group group1 = new Group(students[0..5], "Group1");
            Group group2 = new Group(students[5..10], "Group2");
            Group group3 = new Group(students[10..], "Group3");


            group2.ShowInfo();                                  Console.WriteLine();

            group2.ShowBestBiologyMark();                       Console.WriteLine();
            group2.ShowBestMathMark();                          Console.WriteLine();
            group2.ShowBestPhysicalEducationMark();             Console.WriteLine();

            group2.SetReward();                                 Console.WriteLine();

            group2.ShowInfo();
        }
    }
}