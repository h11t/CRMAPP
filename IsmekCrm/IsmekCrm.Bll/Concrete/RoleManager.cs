using IsmekCrm.Bll.Abstract;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace IsmekCrm.Bll.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleRepository _roleService;
        public RoleManager(IRoleRepository roleService)
        {
            _roleService = roleService;
        }
        public void Add(Role entity)
        {
            _roleService.Add(entity);
        }

        public void Delete(int id)
        {
            _roleService.Delete(new Role { Id = id });
        }

        public List<Role> GetAll()
        {
            return _roleService.GetList().ToList();
        }

        public Role GetById(int id)
        {
            return _roleService.Get(x => x.Id == id);
        }

        public void Update(Role entity)
        {
            _roleService.Update(entity);
        }
    }
}
