using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
    public class Status : Base
    {
        public Status()
        {
            Tasks = new HashSet<Task>();
        }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
