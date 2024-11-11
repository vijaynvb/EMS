using EMSApi.Implementation;
using EMSApi.Interfaces;
using EMSApi.Models;
using EMSApi.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // ILogs _logs;
        //EmployeStaticImp employeeImp;
        IEmployee employeeImp;

        // DI is going to inject the File logs object
        /*public EmployeesController(ILogs logs, EmployeStaticImp empImp)
        {
            _logs = logs;
            employeeImp= empImp;
        }*/

        public EmployeesController(IEmployee emsImpl)
        {
            employeeImp =emsImpl;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public List<Employee> Get()
        {
            //_logs.WriteLog("Get All employees was called");
            List<Employee> employees = employeeImp.GetEmployees();
            //_logs.WriteLog("got all employeess");
            return employees;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employeeImp.GetEmployeeById(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            Employee newEmp =  employeeImp.AddEmployee(emp);
            return;
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
