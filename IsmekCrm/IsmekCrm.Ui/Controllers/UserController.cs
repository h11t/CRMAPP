using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Bll.Abstract;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Ui.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsmekCrm.Ui.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        IDepartmentService departmentService;
        public UserController(IUserService _userService, IDepartmentService _departmentService)
        {
            userService = _userService;
            departmentService = _departmentService;
        }
        public IActionResult Index(int? id)
        {
            List<User> data;
            Department department;
            if (id != null)
            {
                department = departmentService.GetById((Int32)id);
                data = userService.GetAll().FindAll(x => x.Departments.Contains(new UserDepartment { DepartmentId = department.Id }));
            }
            else
            {
                data = userService.GetAll();
            }
            return View(new UserViewModel { ListUser = data });
            
        }
        public IActionResult List()
        {
            var list = userService.GetAll();
            return View(new UserViewModel { ListUser = list });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                userService.Add(user);
                ViewBag.Message = "User is added succesfully.";
                return View();
            }
            else
            {
                ViewBag.Message = "Opss! There are some validation errors. Please check up";
                return View(user);
            }
        }
    }
}