    namespace GitHome5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCreator studentCreator = new StudentCreator();
            Student[] studentsArrayGroup1 = studentCreator.CreateStudent("Not Ice");
            Student[] studentsArrayGroup2 = studentCreator.CreateStudent("Ice!!");
            Student[] studentsArrayGroup3 = studentCreator.CreateStudent("Pro");

            //foreach (Student[] stusdent in group1)
           
            //    for(int i = 0; i < studentsArrayGroup1.Length; i++)
            //    {
            //    Console.WriteLine(studentsArrayGroup1[i].Age);
            //    }
            //foreach (Student student in studentsArrayGroup1)
            //{
            //    for(int i = 0)
            //}
            int max;
            max  = 0;
            //double average = matrix[0];

            for (int i = 1; i < studentsArrayGroup1.Length; i++)
            {
                //average += matrix[i];
                if (studentsArrayGroup1[i].MathMark > max && studentsArrayGroup1[i].MathMark != max)
                {
                    max = studentsArrayGroup1[i].MathMark;
                }
            }
            Console.WriteLine(max);
            //group1.ShowBestMarkStudent(group1);
        }
    }
}