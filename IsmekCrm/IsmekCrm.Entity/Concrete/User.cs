using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            Departments = new HashSet<Department>();
            Tasks = new HashSet<Task>();
            Roles = new HashSet<Role>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Username must be 5-20 characters", MinimumLength = 5)]
        public string Username { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Password must be 5-20 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public int UserStatusId { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
