using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesSystem.Models;

namespace SalesSystem.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Computers" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}