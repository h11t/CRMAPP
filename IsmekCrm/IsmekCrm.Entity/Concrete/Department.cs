using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
  public  class Department:Base
    {
        
        public  ICollection<UserDepartment> Users { get; set; }
    }
}
