using IsmekCrm.Bll.Abstract;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace IsmekCrm.Bll.Concrete
{
    public class UserManager : IUserService
    {
        //dependency inversion prensibini uyguladık
        IUserRepository _userService;
        public UserManager(IUserRepository userService)
        {
            _userService = userService;
        }
        public void Add(User entity)
        {
            _userService.Add(entity);
        }

        public void Delete(int id)
        {
            _userService.Delete(new User { Id = id });
        }

        public List<User> GetAll()
        {
            return _userService.GetList().ToList();
        }

        public List<User> GetByFilter(Expression<Func<User, bool>> filter)
        {
            return _userService.GetList(filter).ToList();
        }

        public User GetById(int id)
        {
            return _userService.Get(x => x.Id == id);
        }

        public bool Login(string userName, string password)
        {
           var user= _userService.Get(x => x.Username == userName && x.Password == password);
            return user == null ? false : true;
        }

        public void Update(User entity)
        {
            _userService.Update(entity);
        }
    }
}
