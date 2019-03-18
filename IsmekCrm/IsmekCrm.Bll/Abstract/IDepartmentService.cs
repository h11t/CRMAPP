using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;

namespace IsmekCrm.Bll.Abstract
{
    public  interface IDepartmentService
    {
        void Add(Department entity);
        void Update(Department entity);
        void Delete(int id);
        Department GetById(int id);
        List<Department> GetAll();
    }
}
