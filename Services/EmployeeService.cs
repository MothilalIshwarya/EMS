using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.DataAccessLayer;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Validations;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService : Iservice
    {
        private readonly IRepository _repo;
        public EmployeeService(IRepository _EmployeeRepository)
        {
            _repo = _EmployeeRepository;
        }
        public IEnumerable<EmployeeDetails> GetAllEmployeeDetails()
        {
            return _repo.GetAllEmployeeDetails();
        }
        public EmployeeDetails GetEmployeeDetailById(int id)
        {
            return _repo.GetEmployeeDetailById(id);

        }
        public bool CreateEmployee(EmployeeDetails employeeDetails)
        {
            Validation.EmployeeValidation(employeeDetails);

            return _repo.CreateEmployee(employeeDetails);

        }
        public bool UpdateEmployee(EmployeeDetails employeeDetails)
        {
            Validation.EmployeeValidation(employeeDetails);

            return _repo.UpdateEmployee(employeeDetails);

        }
        public bool DeleteEmployee(int id)
        {
            return _repo.DeleteEmployee(id);

        }

    }
}