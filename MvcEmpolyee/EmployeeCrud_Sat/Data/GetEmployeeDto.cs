using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud_Sat.Data
{
    public class GetEmployeeDto
    {   
        public int EmployeeId { get; set; } 
        public string EmployeeCode { get; set; } //this should be uniq autgernerated   e.g., 001
        
        public string FirstName { get; set; }
       
        public string LastName { get; set; }       

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string CoutryName { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
       
        public string EmailAddress { get; set; }

       
        public string MobileNumber { get; set; }

       
        public string PanNumber { get; set; }

       
        public string PassportNumber { get; set; }

       
        public string ProfileImage { get; set; }

        public string Gender { get; set; }


        public string DateOfBirth { get; set; }

        public string? DateOfJoinee { get; set; }
        public bool? IsActive { get; set; }
   

    }
}
