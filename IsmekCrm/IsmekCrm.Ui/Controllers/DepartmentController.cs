using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Bll.Abstract;
using IsmekCrm.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IsmekCrm.Ui.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService departmentService;
        public DepartmentController(IDepartmentService _departmentService)
        {
            departmentService = _departmentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                departmentService.Add(department);
                ViewBag.Message = "Department is added succesfully.";
                return View();
            }
            else
            {
                ViewBag.Message = "Opss! There are some validation errors. Please check up";
                return View(department);
            }
        }
    }
}