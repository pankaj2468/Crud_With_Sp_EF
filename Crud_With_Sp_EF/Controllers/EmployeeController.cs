using Crud_With_Sp_EF.Models;
using Crud_With_Sp_EF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_With_Sp_EF.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }
        public IActionResult Index()
        {
            var list=_employee.GetAllEmployees();
            return View(list);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            _employee.Create(employee);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

           var list=_employee.GetEmpById(id);
            
            return View(list);
        }

        [HttpPost]
        public  IActionResult Edit(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _employee.Update(employee);
            return RedirectToAction("Index");
        }



        public IActionResult Details(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var list=_employee.GetEmpById(id);
            
            return View(list);
        }



        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _employee.Delete(id);
            
            return RedirectToAction("Index");
        }
    }
}
