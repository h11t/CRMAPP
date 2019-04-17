using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Bll.Abstract;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Ui.Extentions;
using IsmekCrm.Ui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsmekCrm.Ui.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        IDepartmentService departmentService;
        IHttpContextAccessor accessor;

        public UserController(IUserService _userService, IDepartmentService _departmentService, IHttpContextAccessor _accessor)
        {
            userService = _userService;
            departmentService = _departmentService;
            accessor = _accessor;
        }

        public IActionResult Index(int? id)
        {
            HttpContext.Session.SetInt32("id", 1);
            HttpContext.Session.SetString("name", "hilal");
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
            var sessionId=HttpContext.Session.GetInt32("id");
             var sessionName=HttpContext.Session.GetString("name");
            return View(new UserViewModel { ListUser = data });
            
        }

        public IActionResult List()
        {
            var list = userService.GetAll();
            return View(new UserViewModel { ListUser = list });
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    userService.Add(user);
                    ViewBag.Message = "User is added succesfully.";
                    return RedirectToAction("Login");
                }
                catch (Exception)
                {

                    return View(user);
                }
            }
            else
            {
                ViewBag.Message = "Opss! There are some validation errors. Please check up";
                return View(user);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
          bool isLogin=  userService.Login(model.Username, model.Password);
            if (isLogin)
            {
                accessor.HttpContext.Session.SetObject("currentUser", model);
                return RedirectToAction("Profile");
            }
            else return View();
        }

        public IActionResult Profile()
        {
           User currentUser= accessor.HttpContext.Session.GetObject<User>("currentUser");
            if (currentUser!=null)
            {
                return View(new UserViewModel {  CurrentUser=currentUser});
            }
            else
            {
                return RedirectToAction(nameof(Login));
            }
        }

        public IActionResult Logout()
        {
            accessor.HttpContext.Session.Remove("currentUser");
            return RedirectToAction("Index", "Home");
        }
    }
}