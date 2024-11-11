using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApi.Models
{
    // poco
    public class Employee // Task
    {
        //[Key] // configuration for efc
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        
        public int DepartmentId { get; set; }
        //public Department Department { get; set; } // user 
        public Employee()
        {
        }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
