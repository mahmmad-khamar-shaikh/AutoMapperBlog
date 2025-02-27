﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperBlog.Data.Entities
{
    public class DepartmentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}
