using System.Collections.Generic;

namespace IsmekCrm.Ui.Models
{
    public class TaskViewModel
    {
        public List<IsmekCrm.Entity.Concrete.Task> TaskList { get; set; }
        public IsmekCrm.Entity.Concrete.Task Task { get; set; }
    }
}
