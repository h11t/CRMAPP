using System;
using System.Collections.Generic;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
  public   class UserDepartment
    {
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; }
    }
}
