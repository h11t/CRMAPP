using IsmekCrm.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
  public  class Base:IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
