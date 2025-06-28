using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud_Sat.Models
{
    public class Employee
    {        
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(8)]
        public string EmployeeCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }

        [ForeignKey("City")]
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

        [MaxLength(100)]
        public string ProfileImage { get; set; }

        public byte Gender { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfJoinee { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        // Navigation Properties
        public Country? Country { get; set; }
        public State? State { get; set; }
        public City? City { get; set; }
    }
}
