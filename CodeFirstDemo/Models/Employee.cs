using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CodeFirstDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        public  Department Departments { get; set; }
    }
}