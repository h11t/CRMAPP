using IsmekCrm.Core.DbAccess;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;

namespace IsmekCrm.Dal.Concrete
{
   public class DepartmentRepository: EFBaseRepository<Department, IsmekCrmContext>, IDepartmentRepository
    {
    }
}
