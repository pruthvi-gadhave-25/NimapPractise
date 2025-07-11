using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud_Sat.Controllers
{
    public class CountryController : Controller
    {

        private readonly ICountryInterface _countryInterface;

        public CountryController(ICountryInterface countryInterface)
        {
            _countryInterface = countryInterface;
        }


        [HttpPost]
        public async Task<IActionResult> AddCountry(CountryDtoAdd countryDto)
        {

            _countryInterface.AddCountry(countryDto);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetCountry(CountryDtoAdd countryDto)
        {

            _countryInterface.AddCountry(countryDto);

            return Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
