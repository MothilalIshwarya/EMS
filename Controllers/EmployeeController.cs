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
        private readonly EmployeeService _service;
        public EmployeeController(EmployeeService _EmployeeService){
            _service=_EmployeeService;
        }
        [HttpGet]
        public IActionResult GetAllEmployee(){
            try{
                var User=_service.GetAllEmployeeDetails();
                return User.Count()!=0 ? Ok(User):NotFound("No data Found");
                
            }
            catch(Exception ex){
                return Problem();
            }
        }
        [HttpGet]
        public IActionResult GetEmployeeDetailById(int id){
            if(id<=0) return NotFound("Enter valid EmployeeId");
            try{
                var User=_service.GetEmployeeDetailById(id);
                return User is not null? Ok(User):NotFound("Enter valid EmployeeId");
            }
            catch(Exception ex){
                return Problem();
            }
        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDetails employeeDetails){
           // if(employeeDetails==null) return Problem("Enter valid Details");
            try{
                bool result=_service.CreateEmployee(employeeDetails);
                return result?Ok("Employee Created successfully"):Problem("Something went wrong");
            }
             catch(ValidationException msg){
                return Problem("Error:"+msg);
            }
            catch(Exception ex){
                return Problem();
            }
        }
        [HttpPut]
         public IActionResult UpdateEmployee(EmployeeDetails employeeDetails){
            //if(employeeDetails==null) return Problem("Enter valid Details");
            try{
                bool result=_service.UpdateEmployee(employeeDetails);
                return result?Ok("Employee Updated successfully"):Problem("Something went wrong");
            }
            catch(ValidationException msg){
                return Problem("Error:"+msg);
            }
            catch(Exception ex){
                return Problem();
            }
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int id){
            if(id<=0)return NotFound("Invalid EmployeeId");
            try{
               bool result=_service.DeleteEmployee(id);
                return result?Ok("Employee Deleted successfully"):NotFound("Invalid EmployeeId");
            }
            catch(Exception ex){
                return Problem();
            }
        }
        
    }
}