using System.ComponentModel.DataAnnotations;

namespace WebApp4ByAsim.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters")]
        public string Name { get; set; }
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        public int Age { get; set; }

        [StringLength(50, ErrorMessage = "City must not exceed 50 characters")]
        public string City { get; set; }
    }
}
