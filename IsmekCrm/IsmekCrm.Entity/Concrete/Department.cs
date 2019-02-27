using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
  public  class Department:Base
    {
        public Department()
        {
            Users = new HashSet<User>();
        }
        public virtual ICollection<User> Users { get; set; }
    }
}
