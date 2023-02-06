using System.ComponentModel.DataAnnotations;

namespace OTO.Model
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public virtual StudentAddress Address { get; set; }
    }
}
