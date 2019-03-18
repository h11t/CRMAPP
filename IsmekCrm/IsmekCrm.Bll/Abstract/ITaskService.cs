using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;

namespace IsmekCrm.Bll.Abstract
{
    public  interface ITaskService
    {
        void Add(Task entity);
        void Update(Task entity);
        void Delete(int id);
        Task GetById(int id);
        List<Task> GetAll();
    }
}
