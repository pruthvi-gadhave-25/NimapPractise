using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Services
{
    public class CountryService : ICountryInterface
    {   

        private     readonly AppDbContext _appDbContext;

        public CountryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> AddCountry(CountryDtoAdd country)
        {   
            try
            {
                if (country == null)
                    return false;

                var newCountry = new Country
                {
                    CountryName = country.CountryName,
                    
                };
                var res = _appDbContext.Country.Add(newCountry);
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

        public async Task<List<Country>> GetAllCountry()
        {
            try
            {
                var res = await _appDbContext.Country.ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
