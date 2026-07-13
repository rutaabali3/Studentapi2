namespace Studentapi2.Models
{
    public class Student
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; } 

        public int Age { get; set; }

        public int Grade { get; set; }
    }
}
