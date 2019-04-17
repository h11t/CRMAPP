using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
    public class User : IEntity
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Username must be 5-20 characters", MinimumLength = 5)]
        public string Username { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Password must be 5-20 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Compare("Password",ErrorMessage ="Passwords does not match")]
        //[NotMapped] db de oluşturulmamasını sağlıuyor.
        //public string PasswordConfirm { get; set; }

        public int UserStatusId { get; set; }

        public  ICollection<UserDepartment> Departments { get; set; }
        public  ICollection<UserTask> Tasks { get; set; }
        public  ICollection<UserRole> Roles { get; set; }
    }
}
