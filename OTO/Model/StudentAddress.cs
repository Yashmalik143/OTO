using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OTO.Model
{
    public class StudentAddress
    {

        [Key]
        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public virtual Student Student { get; set; }

    }
}
