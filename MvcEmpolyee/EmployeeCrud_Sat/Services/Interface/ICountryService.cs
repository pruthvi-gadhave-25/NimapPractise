using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;

namespace EmployeeCrud_Sat.Services.Interface
{
    public interface ICountryInterface
    {
        Task<List<Country>> GetAllCountry();
        Task<bool> AddCountry(CountryDtoAdd country);
    }
}
