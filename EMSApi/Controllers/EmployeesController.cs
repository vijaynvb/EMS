using EMSApi.Implementation;
using EMSApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeStaticImp employeeImp = new EmployeStaticImp();

        // GET: api/<EmployeesController>
        [HttpGet]
        public List<Employee> Get()
        {
            // return data as json 
            // response - 4 components
            List<Employee> employees = employeeImp.GetEmployees();
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
