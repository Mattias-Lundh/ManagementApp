﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
    }
}
