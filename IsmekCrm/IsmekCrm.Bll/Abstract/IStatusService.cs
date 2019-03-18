using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;

namespace IsmekCrm.Bll.Abstract
{
    public  interface IStatusService
    {
        void Add(Status entity);
        void Update(Status entity);
        void Delete(int id);
        Status GetById(int id);
        List<Status> GetAll();
    }
}
