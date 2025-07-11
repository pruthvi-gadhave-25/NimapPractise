using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;

namespace EmployeeCrud_Sat.Services.Interface
{
    public interface ICityService
    {
        Task<List<City>> GetAllCities();
        Task<bool>  AddCity(CityDto city);
    }
}
