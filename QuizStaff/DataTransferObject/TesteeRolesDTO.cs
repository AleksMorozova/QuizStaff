﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeRolesDTO
    {
        public Guid Id { get; set; }
        public virtual RoleDTO Role { get; set; }
        public virtual TesteeDTO Testee { get; set; }
        public bool IsActive { get; set; }
    }
}