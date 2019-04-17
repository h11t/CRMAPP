using IsmekCrm.Entity.Concrete;
using IsmekCrm.Ui.Extentions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Ui.ViewComponents
{
    public class CurrentUserViewComponent:ViewComponent
    {
        IHttpContextAccessor _accessor;
        public CurrentUserViewComponent(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public IViewComponentResult Invoke()
        {
            var user = _accessor.HttpContext.Session.GetObject<User>("currentUser");
            if (user!=null)
            {
                return View("DefaultVC", user.Username);
            }
            else
            {
                return View("LoginVC");
            }
        }
    }
}
