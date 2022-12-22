using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class EmployeeRepository : IRepository
    {
        private readonly EMScontext _EMSContext;
        public EmployeeRepository(EMScontext _context)
        {
            _EMSContext = _context;
        }
        public IEnumerable<EmployeeDetails> GetAllEmployeeDetails()
        {
            return _EMSContext.EmployeeDetails.ToList()!;


        }
        public EmployeeDetails GetEmployeeDetailById(int id)
        {

            return _EMSContext.EmployeeDetails.Include(e=>e.Designation).Include(e=>e.gender).Where(e => e.Id == id).FirstOrDefault()!;

        }
        public bool CreateEmployee(EmployeeDetails employeeDetails)
        {
            if (_EMSContext.EmployeeDetails.Any(e => e.Mailid == employeeDetails.Mailid)) throw new ValidationException("Mailid Already Exists");
            if (!_EMSContext.genders.Any(g => g.id == employeeDetails.Genderid)) throw new ValidationException("Enter Valid GenderId");
            if (!_EMSContext.designations.Any(g => g.id == employeeDetails.designationId)) throw new ValidationException("Enter Valid DesignationId");

            _EMSContext.EmployeeDetails.Add(employeeDetails);
            _EMSContext.SaveChanges();
            return true;

        }
        public bool UpdateEmployee(EmployeeDetails employeeDetails)
        {
            if (!_EMSContext.EmployeeDetails.Any(e => e.Id == employeeDetails.Id)) throw new ValidationException("Invalid UserID");
            if (_EMSContext.EmployeeDetails.Any(e => e.Mailid == employeeDetails.Mailid && e.Id != employeeDetails.Id)) throw new ValidationException("Mailid Already Exists");
            _EMSContext.EmployeeDetails.Update(employeeDetails);
            _EMSContext.SaveChanges();
            return true;


        }
        public bool DeleteEmployee(int id)
        {
            var user = _EMSContext.EmployeeDetails.Find(id);

            if (user != null)
            {
                _EMSContext.EmployeeDetails.Remove(user);
                _EMSContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}