namespace EmployeeCrud_Sat.DTO
{
    public class GetEditEmployeeDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string? CountryName { get; set; }

        public string StateName { get; set; }


        public string CityName { get; set; }


        public string EmailAddress { get; set; }


        public string MobileNumber { get; set; }


        public string PanNumber { get; set; }


        public string PassportNumber { get; set; }


        public string ProfileImage { get; set; }

        public string Gender { get; set; }


        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfJoinee { get; set; }
    }
}
