using DI_BL_Model;
using DI_DAL_Repository;
using System;
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
        // GET: Index
        public ActionResult Index()
        {
            var model = _repository.GetAllEmployee();
            return View(model);
        }
        // GET: Details
        public ActionResult Details(Guid Id)
        {
            var model = _repository.GetEmployee(Id);
            return View(model);
        }

        //  
        // GET: /CRUD/Create  

        public ActionResult Create()
        {
            return View();
        }

        //  
        // POST: /CRUD/Create  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repository.RegisterNewEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //  
        // GET: /CRUD/Edit/5  

        public ActionResult Edit(Guid Id)
        {
            var employee = _repository.GetEmployee(Id);
            return View(employee);
        }

        //  
        // POST: /CRUD/Edit/5  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        //  
        // GET: /CRUD/Delete/5  

        public ActionResult Delete(Guid Id)
        {
            var employee = _repository.GetEmployee(Id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //  
        // POST: /CRUD/Delete/5  

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _repository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}