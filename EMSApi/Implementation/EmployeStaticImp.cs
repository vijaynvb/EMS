using EMSApi.Interfaces;
using EMSApi.Models;
using EMSApi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSApi.Implementation
{
    public class EmployeStaticImp : IEmployee // store the data in a give application -> db files, memory
    {
       // private FileLogs _logs;
        private List<Employee> employees = new List<Employee>();

        public EmployeStaticImp()
        {
            employees.Add(new Employee(1,"Vijay", 12));
            employees.Add(new Employee(2, "vj", 1));
            employees.Add(new Employee(3, "jai", 10));
            employees.Add(new Employee(4, "veeru", 3));
        }

        /*public EmployeStaticImp(FileLogs logs)
        {
            this._logs = logs;
        }*/

        public Employee AddEmployee(Employee employee)
        {
            //_logs.WriteLog("add employee implementation called");
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
            //_logs.WriteLog("get all employees implementation called");
            return employees;
        }

        public Employee UpdateEmployee(int id, int Age)
        {
            Employee employee = employees.Find(x => x.Id == id);
            employees.Remove(employee);
            employees.Add(employee);
            return employee;

        }
    }
}
