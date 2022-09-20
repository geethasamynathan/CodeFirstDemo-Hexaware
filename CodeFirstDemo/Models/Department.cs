using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual List<Employee> Employees { get; set; }

    }
}