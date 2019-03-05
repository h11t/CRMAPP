using IsmekCrm.Core.DbAccess;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsmekCrm.Dal.Concrete
{
    public class UserRepository : EFBaseRepository<User, IsmekCrmContext>, IUserRepository
    {
        public List<User> OrderByIdAsc()
        {
            using (var context =new IsmekCrmContext())
            {
                return context.Set<User>().OrderBy(x => x.Id).ToList();
            }
        }

        public List<User> OrderByIdDesc()
        {
            using (var context = new IsmekCrmContext())
            {
                return context.Set<User>().OrderByDescending(x => x.Id).ToList();
            }
        }
    }
}
