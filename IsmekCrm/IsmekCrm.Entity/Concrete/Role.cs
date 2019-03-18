using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
  public  class Role:Base
    {
        
        public  ICollection<UserRole> Users { get; set; }

    }
}
