using EMS.Interfaces;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Implementation
{
    class EmployeStaticImp : IEmployee // store the data in a give application -> db files, memory
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeStaticImp()
        {
            employees.Add(new Employee(1,"Vijay", 12));
            employees.Add(new Employee(2, "vj", 1));
            employees.Add(new Employee(3, "jai", 10));
            employees.Add(new Employee(4, "veeru", 3));
        }

        public Employee AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = employees.Find(x => x.Id == id);
            if(employee != null)
                employees.Remove(employee);
            return employee;
        }

        public Employee GetEmployeeById(int Id)
        {
            Employee employee = employees.Find(x => x.Id == Id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee UpdateEmployee(int id, int Age)
        {
            Employee employee = employees.Find(x => x.Id == id);

            return newEmployeeValye;

        }
    }
}
