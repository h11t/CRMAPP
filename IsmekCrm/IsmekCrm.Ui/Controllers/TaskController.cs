using System;
using System.Collections.Generic;
using System.Linq;
using IsmekCrm.Entity.Concrete;
using IsmekCrm.Bll.Abstract;
using IsmekCrm.Ui.Models;
using Microsoft.AspNetCore.Mvc;

namespace IsmekCrm.Ui.Controllers
{
    public class TaskController : Controller
    {
        ITaskService taskService;
        IStatusService statusService;
        public TaskController(ITaskService _taskService, IStatusService _statusService)
        {
            taskService = _taskService;
            statusService = _statusService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
           var list= statusService.GetAll();
            return View(new TaskViewModel {  StatusList=list, Task=new Task { } });
        }

        [HttpPost]
        public IActionResult Add(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                taskService.Add(model.Task);
                ViewBag.Message = "Task is added successfully. Thanks.";
                return View();
            }
            else
            {
                ViewBag.Message = "Opss! There are some validation errors. Please check up";
                return View(model.Task);
            }
        }

        public IActionResult List()
        {
            var list = taskService.GetAll();
            return View(new TaskViewModel {  TaskList=list});
        }

        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return RedirectToAction("List");
            }
            Task result = taskService.GetById((int)id);
            return View(new TaskViewModel { Task = result });
        }

        [HttpPost]
        public IActionResult Edit(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                taskService.Update(model.Task);
                ViewBag.Message = "The record has been updated successfully";
            }
            else
            {
                ViewBag.Message = "The record hasn't been updated.Try again";
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            var result = taskService.GetById(id);
            return View(new TaskViewModel { Task=result});
        }

        public IActionResult Delete(int id)
        {
            taskService.Delete(id);
            return RedirectToAction("List");
        }
        
    }
}