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
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        public IActionResult Index()
        {
            return View();
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
    }
}