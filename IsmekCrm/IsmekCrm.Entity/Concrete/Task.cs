using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
   public class Task:IEntity
    {
       
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public int StatusId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public  ICollection<UserTask> Users { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Statuss { get; set; }

    }
}
