using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud_Sat.Data
{
    public class GetEmployeeDto
    {
        public string EmployeeCode { get; set; } //this should be uniq autgernerated   e.g., 001
        
        public string FirstName { get; set; }
       
        public string LastName { get; set; }       
        public string CountryName { get; set; }
     
        public string StateName { get; set; }

       
        public string CityName { get; set; }

       
        public string EmailAddress { get; set; }

       
        public string MobileNumber { get; set; }

       
        public string PanNumber { get; set; }

       
        public string PassportNumber { get; set; }

       
        public string ProfileImage { get; set; }

        public byte Gender { get; set; }


        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfJoinee { get; set; }

        
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

    }
}
