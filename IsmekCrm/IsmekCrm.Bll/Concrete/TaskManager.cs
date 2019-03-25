using IsmekCrm.Bll.Abstract;
using IsmekCrm.Dal.Abstract;
using IsmekCrm.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace IsmekCrm.Bll.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskRepository _taskService;
        public TaskManager(ITaskRepository taskService)
        {
            _taskService = taskService;
        }
        public void Add(Task entity)
        {
            _taskService.Add(entity);
        }

        public void Delete(int id)
        {
            _taskService.Delete(new Task { Id = id });
        }

        public List<Task> GetAll()
        {
            return _taskService.GetList().ToList();
        }

        public List<Task> GetByFilter(Expression<Func<Task, bool>> filter)
        {
            return _taskService.GetList(filter).ToList();
        }

        public Task GetById(int id)
        {
           return _taskService.Get(x => x.Id == id);
        }

        public void Update(Task entity)
        {
            _taskService.Update(entity);
        }
    }
}
