using IsmekCrm.Core.DbAccess;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsmekCrm.Dal.Concrete
{
  public  class TaskRepository:EFBaseRepository<Task,IsmekCrmContext>,ITaskRepository
    {
    }
}
