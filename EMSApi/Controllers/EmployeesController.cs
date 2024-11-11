using EMSApi.DTO;
using EMSApi.Implementation;
using EMSApi.Interfaces;
using EMSApi.Models;
using EMSApi.Utils;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

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

        // api/employees
        [HttpGet]
        public ActionResult<List<Employee>> Get() // action , IActionResult
        {
            //_logs.WriteLog("Get All employees was called");
            List<Employee> employees = employeeImp.GetEmployees();
            if(employees == null)
                return NoContent();
            //_logs.WriteLog("got all employeess");

            return Ok(employees); // data -> body, status, http version, http headers
        }

        // GET api/<EmployeesController>/5
        // api/employees/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee emp = employeeImp.GetEmployeeById(id);
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }

        // POST api/<EmployeesController>
        [HttpPost]

        // model binding -> validation framework
        [SwaggerResponse(((int)HttpStatusCode.OK))]
        [SwaggerResponse(((int)HttpStatusCode.BadRequest))]
        [SwaggerResponse(((int)HttpStatusCode.Created))]

        public ActionResult<Employee> Post([FromBody] EmployeeDTO emp) // employee age should be 18 above
        {
            if(emp.Age < 18)
            {
                ModelState.AddModelError("Age", "Invalid age");
                return BadRequest(ModelState);
            }


            Employee employeeValue = new Employee();
            employeeValue.Name = emp.Name;
            employeeValue.Age = emp.Age;
            employeeValue.DepartmentId = emp.DepartmentId;
            employeeValue.Email = emp.Email;

            Employee newEmp =  employeeImp.AddEmployee(employeeValue);

            if(newEmp == null)
                return BadRequest();

            return Created("",newEmp);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] string value)
        {
            Employee newEmp = employeeImp.UpdateEmployee(id, 1);

            if (newEmp == null)
                return BadRequest();

            return Accepted("", newEmp);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id)
        {
            Employee newEmp = employeeImp.DeleteEmployee(id);

            if (newEmp == null)
                return NotFound();

            return Accepted("", newEmp);
        }
    }
}
