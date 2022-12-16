using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.DataAccessLayer;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Validations;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _Repo;
        public EmployeeService(EmployeeRepository _EmployeeRepository){
            _Repo=_EmployeeRepository;
        }
        public IEnumerable<EmployeeDetails> GetAllEmployeeDetails(){
            try{
                return _Repo.GetAllEmployeeDetails();
            }
            catch(Exception ex){
                throw;
            }
        }
        public EmployeeDetails GetEmployeeDetailById(int id){
            try{
                return _Repo.GetEmployeeDetailById(id);
            }
             catch(Exception ex){
                throw;
            }
        }
        public bool CreateEmployee(EmployeeDetails employeeDetails){
           EMSValidation.EmployeeValidation(employeeDetails);
            try{
                 return _Repo.CreateEmployee(employeeDetails);
            }
            catch(ValidationException msg){
                throw;
            }
            catch(Exception ex){
                  return false;
            }
        }
        public bool UpdateEmployee(EmployeeDetails employeeDetails){
            EMSValidation.EmployeeValidation(employeeDetails);
            try{
                return _Repo.UpdateEmployee(employeeDetails);
            }
             catch(ValidationException msg){
                throw;
            }
            catch(Exception ex){
                return false;
            }
        }
        public bool DeleteEmployee(int id){
            try{
                return _Repo.DeleteEmployee(id);
            }
            catch(Exception ex){
                return false;
            }
        }

    }
}