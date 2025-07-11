using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Services
{
    public class CityService :ICityService
    {
        private readonly AppDbContext _appDbContext;

        public CityService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async  Task<bool> AddCity(CityDto city)
        {
            try
            {
                if (city == null)
                    return false;

                var newCity = new City
                {
                    Name = city.CityName,
                    StateId = city.StateId,
                };
                var res = _appDbContext.Cities.Add(newCity);
                await _appDbContext.SaveChangesAsync();

                if (res != null)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public  async Task<List<City>> GetAllCities()
        {
            try
            {
                var res = await _appDbContext.Cities.ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
