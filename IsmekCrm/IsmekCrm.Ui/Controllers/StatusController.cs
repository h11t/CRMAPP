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
    public class StatusController : Controller
    {
        IStatusService statusService;
        ITaskService taskService;
        public StatusController(IStatusService _statusService, ITaskService _taskService)
        {
            statusService = _statusService;
            taskService = _taskService;
        }
        public IActionResult Index(int? id)
        {
            List<IsmekCrm.Entity.Concrete.Task> data;
            if (id != null)
            {
                 data = taskService.GetByFilter(x => x.StatusId == id);
            }
            else
            {
                 data = taskService.GetAll();
            }
            return View(new TaskViewModel {TaskList=data });
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
                ViewData["Alert"] = "Please refresh page";
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
            return View(new StatusViewModel { StatusList=list});
        }
    }
}