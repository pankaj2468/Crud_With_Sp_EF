using System.ComponentModel.DataAnnotations;

namespace Crud_With_Sp_EF.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Id")]
        public int Empid { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
    }
}
