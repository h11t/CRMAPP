using IsmekCrm.Bll.Abstract;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace IsmekCrm.Bll.Concrete
{
    public class StatusManager : IStatusService
    {
        IStatusRepository _statusService;
        public StatusManager(IStatusRepository statusService)
        {
            _statusService = statusService;
        }
        public void Add(Status entity)
        {
            _statusService.Add(entity);
        }

        public void Delete(int id)
        {
            _statusService.Delete(new Status { Id = id });
        }

        public List<Status> GetAll()
        {
          return  _statusService.GetList().ToList();
        }

        public Status GetById(int id)
        {
           return _statusService.Get(x => x.Id == id);
        }

        public void Update(Status entity)
        {
            _statusService.Update(entity);
        }
    }
}
