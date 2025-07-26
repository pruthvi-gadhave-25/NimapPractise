using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EmployeeCrud_Sat.DTO
{
    public class AddEmployeeDto
    {       

        public int EmployeeId { get; set; }
        [Required]  
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a country.")]
        public int CountryId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a state.")]
        public int StateId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a city.")]
        public int CityId { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(15)]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(12)]
        public string PanNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string PassportNumber { get; set; }

        [Required]
        [Range(0, 2, ErrorMessage = "Select a valid gender.")]
        public byte Gender { get; set; } // Assuming 0 = Male, 1 = Female, 2 = Other

        [Required]
        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfJoinee { get; set; }

        [Required]
        public IFormFile ProfileImage { get; set; }


        [BindNever]
        public IEnumerable<SelectListItem> Countries { get; set; }

        [BindNever]
        public IEnumerable<SelectListItem> States { get; set; }

        [BindNever]
        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}
