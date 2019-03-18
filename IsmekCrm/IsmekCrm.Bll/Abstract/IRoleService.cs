using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;

namespace IsmekCrm.Bll.Abstract
{
    public  interface IRoleService
    {
        void Add(Role entity);
        void Update(Role entity);
        void Delete(int id);
        Role GetById(int id);
        List<Role> GetAll();
    }
}
