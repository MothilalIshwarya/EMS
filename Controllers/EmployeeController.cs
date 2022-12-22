using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Model;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Controllers
{
    [ApiController]
    [Route("[Controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly Iservice _service;
        public EmployeeController(Iservice _EmployeeService)
        {
            _service = _EmployeeService;
        }
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var User = _service.GetAllEmployeeDetails();
            return User.Count() != 0 ? Ok(User) : BadRequest("No data Found");
        }
        [HttpGet]
        public IActionResult GetEmployeeDetailById(int id)
        {
            if (id <= 0) return BadRequest("Enter valid EmployeeId");
            var User = _service.GetEmployeeDetailById(id);
            return User is not null ? Ok(User) : BadRequest("Enter valid EmployeeId");
           // return Ok(_service.GetEmployeeDetailById(id));
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDetails employeeDetails)
        {
            if (employeeDetails == null) return BadRequest("Enter valid Details");
            bool result = _service.CreateEmployee(employeeDetails);
            return result ? Ok("Employee Created successfully") : BadRequest("Something went wrong");
        }
        [HttpPut]
        public IActionResult UpdateEmployee(EmployeeDetails employeeDetails)
        {
            if (employeeDetails == null) return BadRequest("Enter valid Details");
            bool result = _service.UpdateEmployee(employeeDetails);
            return result ? Ok("Employee Updated successfully") : BadRequest("Something went wrong");
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            if (id <= 0) return BadRequest("Invalid EmployeeId");
            bool result = _service.DeleteEmployee(id);
            return result ? Ok("Employee Deleted successfully") : BadRequest("Invalid EmployeeId");
        }

    }
}