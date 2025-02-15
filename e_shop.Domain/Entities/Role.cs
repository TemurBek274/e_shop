﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public  class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Privlegs { get; set; }
        public DateTime CreatedAp { get; set; }
        public DateTime UpdatedAp { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public ICollection<StaffRole> StaffRoles { get; set; }
    }
}
