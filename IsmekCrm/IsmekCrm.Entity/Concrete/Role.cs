using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
  public  class Role:Base
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        public virtual ICollection<User> Users { get; set; }

    }
}
