using Bogus.Extensions.Italy;
using DataBase;
using DataBase.Dto;

namespace _Tests
{
    internal class DataBaseTest
    {
        [Test]
        public void Test() 
        {
            var students = new StudentTable().ReadFromTable();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.Name}, {student.Group_id}");
            }


            new StudentTable().CreateStudent(new Student
            {
                Name = "Test",
                Group_id= 1,
            });

            students = new StudentTable().ReadFromTable();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.Name}, {student.Group_id}");
            }
        }
    }
}
