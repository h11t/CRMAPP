using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Bll.Abstract;
using IsmekCrm.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IsmekCrm.Ui.Controllers
{
    public class StatusController : Controller
    {
        IStatusService statusService;
        public StatusController(IStatusService _statusService)
        {
            statusService = _statusService;
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
        public IActionResult Add(Status model)
        {
            if (ModelState.IsValid)
            {
                statusService.Add(model);
                ViewBag.Message = "Status is added successfully. Thanks.";
                return View();
            }
            else
            {
                ViewBag.Message = "Opss! There are some validation errors. Please check up";
                return View(model);
            }
        }
        public IActionResult List()
        {
            var list = statusService.GetAll();
            return View(list);
        }
    }
}