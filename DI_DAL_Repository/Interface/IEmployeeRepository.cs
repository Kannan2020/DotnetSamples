using DI_BL_Model;
using System;
using System.Collections.Generic;

namespace DI_DAL_Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        void RegisterNewEmployee(Employee model);
        Employee GetEmployee(Guid EmployeeId);
        void UpdateEmployee(Employee model);
        void DeleteEmployee(Guid model);

    }
}
