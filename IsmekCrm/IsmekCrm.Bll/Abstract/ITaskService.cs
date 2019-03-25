using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IsmekCrm.Bll.Abstract
{
    public  interface ITaskService
    {
        void Add(Task entity);
        void Update(Task entity);
        void Delete(int id);
        Task GetById(int id);
        List<Task> GetAll();
        List<Task> GetByFilter(Expression<Func<Task, bool>> filter);

    }
}
