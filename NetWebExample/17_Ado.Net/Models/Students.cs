using System.ComponentModel.DataAnnotations;

namespace _17_Ado.Net.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age is required.")]
        [Range(1,120, ErrorMessage = "Age must be between 1 and 120.")]
        public int Age { get; set; }
    }
}
