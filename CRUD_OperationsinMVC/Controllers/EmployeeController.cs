using CRUD_OperationsinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsinMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int departmentId)
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            List<Employee> employees = dbContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            Employee employee = dbContext.Employees.Single(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}