using DI_DAL_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        // GET: Employee
        [HttpGet]
        public ActionResult Employee()
        {
            var model = _repository.GetAllEmployee();
            return View(model);
        }
    }
}