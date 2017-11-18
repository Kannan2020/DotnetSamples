using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_BL_Model;

namespace DI_DAL_Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void DeleteEmployee(Guid model)
        {
            using (Context context = new Context())
            {
                var employee = context.Employee.Find(model);
                context.Entry(employee).State = System.Data.Entity.EntityState.Detached;
                context.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            using (Context context = new Context())
            {
                IList<Employee> employee = context.Employee.ToList<Employee>();
                return employee;
            }
        }

        public Employee GetEmployee(Guid EmployeeId)
        {
            using (Context context = new Context())
            {
                var employee = context.Employee.Find(EmployeeId);
                return employee;
            }
        }

        public void RegisterNewEmployee(Employee model)
        {
            using (Context context = new Context())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee model)
        {
            using (Context context = new Context())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
