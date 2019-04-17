using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Ui.Models
{
    public class UserViewModel
    {
        public List<User> ListUser { get; set; }
        public User CurrentUser { get; set; }
    }
}
