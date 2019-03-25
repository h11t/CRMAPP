using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IsmekCrm.Bll.Abstract
{
    public interface IUserService
    {
        void Add(User entity);
        void Update(User entity);
        void Delete(int id);
        User GetById(int id);
        List<User> GetAll();
        List<User> GetByFilter(Expression<Func<User,bool>> filter);
    }
}
