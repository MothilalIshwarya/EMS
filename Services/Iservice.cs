using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Services
{
    public interface Iservice
    {
        public IEnumerable<EmployeeDetails> GetAllEmployeeDetails();
        public EmployeeDetails GetEmployeeDetailById(int id);
        public bool CreateEmployee(EmployeeDetails employeeDetails);

        public bool UpdateEmployee(EmployeeDetails employeeDetails);


        public bool DeleteEmployee(int id);

    }
}