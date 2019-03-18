using IsmekCrm.Bll.Abstract;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

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

        public User GetById(int id)
        {
            return _userService.Get(x => x.Id == id);
        }

        public void Update(User entity)
        {
            _userService.Update(entity);
        }
    }
}
