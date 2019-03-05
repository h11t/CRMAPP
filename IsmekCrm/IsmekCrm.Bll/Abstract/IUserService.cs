using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
