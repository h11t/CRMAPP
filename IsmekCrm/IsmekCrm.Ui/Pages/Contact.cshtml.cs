using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsmekCrm.Ui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IsmekCrm.Ui.Pages
{
    public class ContactModel : PageModel
    {   
        [BindProperty]
        public ContactMe ContactMe { get; set; }
        
        public void OnGet()
        {
        }

        //public void OnPost(ContactModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        TempData["Data"] = "Your data is received.";
        //    }
            
        //}
        public ActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TempData["Data"] = "Your data is received.";
            }
            return Page();
        }
    }
}