using EmployeeCrud_Sat.Data;
using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;
using EmployeeCrud_Sat.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Services
{
    public class StateService :IStateService
    {
        private readonly AppDbContext _appDbContext;

        public StateService(AppDbContext app)
        {
            _appDbContext = app;
        }

        public async Task<bool> AddState(StateDto state)
        {
            try
            {
                if (state == null)
                    return false;

                var newState = new State
                {
                    Name = state.StateName,
                    CountryId = state.CountryId,
                };
                var res =  _appDbContext.States.Add(newState);
               await  _appDbContext.SaveChangesAsync();

             if(res != null)
                {
                    return true;
                }
             return false;

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public  async Task<List<State>> GetAllStates()
        {
            try
            {
                var res = await _appDbContext.States.ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
