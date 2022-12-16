using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class EmployeeRepository
    {
        private readonly EMScontext _EMSContext;
        public EmployeeRepository(EMScontext _context){
            _EMSContext=_context;
        }
        public IEnumerable<EmployeeDetails> GetAllEmployeeDetails(){
            try{
                return _EMSContext.EmployeeDetails.Where(e=>e.Id!=null).ToList()!;
            }
            catch(Exception ex){
                throw;
            }
            
        }
        public EmployeeDetails GetEmployeeDetailById(int id){
           try{
            return _EMSContext.EmployeeDetails.Where(e=>e.Id==id).FirstOrDefault()!;
            }
            catch(Exception ex){
                throw;
            }
        }
        public bool CreateEmployee(EmployeeDetails employeeDetails){
            if(_EMSContext.EmployeeDetails.Any(e=>e.Mailid==employeeDetails.Mailid))throw new ValidationException("Mailid Already Exists");
            try{
                _EMSContext.EmployeeDetails.Add(employeeDetails);
                _EMSContext.SaveChanges();
                return true;
            }
            catch(Exception ex){
                return false;
            }
        }
        public bool UpdateEmployee(EmployeeDetails employeeDetails){
            var user=_EMSContext.EmployeeDetails.Find(employeeDetails.Id);
            if(_EMSContext.EmployeeDetails.Any(e=>e.Mailid==employeeDetails.Mailid && e.Id!=employeeDetails.Id))throw new ValidationException("Mailid Already Exists");
            try{
                if(user!=null){
                    _EMSContext.EmployeeDetails.Update(employeeDetails);
                    _EMSContext.SaveChanges();
                    return true;
                }
                else{
                    return false;
                }
            }
            catch(Exception ex){
                return false;
            }
        }
        public bool DeleteEmployee(int id){
            var user=_EMSContext.EmployeeDetails.Find(id);
            try{
            if(user!=null){
                _EMSContext.EmployeeDetails.Remove(user);
                _EMSContext.SaveChanges();
                return true;
            }
            else{
                return false;
            }
            }
            catch(Exception ex){
                return false;
            }

        }
    }
}