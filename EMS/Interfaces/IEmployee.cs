using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Interfaces
{
    public interface IEmployee
    {
        public List<Employee> GetEmployees();

        public Employee GetEmployeeById(int Id);

        public Employee AddEmployee(Employee employee);

        public Employee UpdateEmployee(int id, int Age);

        public Employee DeleteEmployee(int id);
    }
}
