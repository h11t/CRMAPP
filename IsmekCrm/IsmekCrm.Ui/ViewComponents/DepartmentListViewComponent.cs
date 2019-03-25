using IsmekCrm.Bll.Abstract;
using IsmekCrm.Ui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Ui.ViewComponents
{   
    
    public class DepartmentListViewComponent:ViewComponent
    {
        IDepartmentService departmentService;
        public DepartmentListViewComponent(IDepartmentService _departmentService)
        {
            departmentService = _departmentService;
        }

        public ViewViewComponentResult Invoke()
        {
            return View("DepartmentList",new DepartmentViewModel {  DepartmentList=departmentService.GetAll()});
        }
    }
}
