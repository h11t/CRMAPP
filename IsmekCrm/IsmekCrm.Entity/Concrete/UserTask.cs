﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IsmekCrm.Entity.Concrete
{
    public class UserTask
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public User User { get; set; }
        public Task Task { get; set; }
    }
}
