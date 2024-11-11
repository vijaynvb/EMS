using EMSApi.Data;
using EMSApi.Interfaces;
using EMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSApi.Implementation
{
    public class EmployeeDbImpl : IEmployee
    {
        EMSDbContext _dbContext;

        public EmployeeDbImpl(EMSDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;

        }

        public Employee DeleteEmployee(int id)
        {
            Employee emp = _dbContext.Employees.SingleOrDefault(p => p.Id == id);
            if(emp == null)
                return null;
            _dbContext.Employees.Remove(emp);
            _dbContext.SaveChanges();
            return emp;
        }

        public Employee GetEmployeeById(int Id)
        {
            // select * from employees where id = $Id
            return _dbContext.Employees.SingleOrDefault(p => p.Id == Id);
        }

        public List<Employee> GetEmployees()
        {
           return _dbContext.Employees.ToList();
        }

        public Employee UpdateEmployee(int id, int Age)
        {
            Employee employee = _dbContext.Employees.SingleOrDefault(p => p.Id == id);
            if (employee == null)
                return null;
            employee.Age = Age;
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
            return employee;
        }
    }
}
