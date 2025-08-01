﻿using EmployeeCrud_Sat.DTO;
using EmployeeCrud_Sat.Models;

namespace EmployeeCrud_Sat.Services.Interface
{
    public interface IStateService
    {
        Task<List<State>> GetAllStates();
        Task<bool> AddState(StateDto state );
    }
}
