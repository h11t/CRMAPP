using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;

namespace IsmekCrm.Bll.Abstract
{
    public interface IUserService
    {
        void Add(User entity);
        void Update(User entity);
        void Delete(int id);
        User GetById(int id);
        List<User> GetAll();
    }
}
