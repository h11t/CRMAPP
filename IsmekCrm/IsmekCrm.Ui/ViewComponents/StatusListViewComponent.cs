using IsmekCrm.Bll.Abstract;
using IsmekCrm.Ui.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Ui.ViewComponents
{
    public class StatusListViewComponent:ViewComponent
    {
        IStatusService statusService;
        public StatusListViewComponent(IStatusService _statusService)
        {
            statusService = _statusService;
        }

        public IViewComponentResult Invoke()
        {
            StatusViewModel model = new StatusViewModel { StatusList = statusService.GetAll() };
            return View("StatusList",model);
        }
    }
}
