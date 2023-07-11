using System.ComponentModel.DataAnnotations;

namespace DataBase.Dto
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Group_id { get; set; }
    }
}
