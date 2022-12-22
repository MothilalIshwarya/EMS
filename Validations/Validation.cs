using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Validations
{
    public static class Validation
    {
        public static void EmployeeValidation(EmployeeDetails employeeDetails)
        {
            if(string.IsNullOrEmpty(employeeDetails.Name))throw new ValidationException("Enter UserName");
            else if (!Regex.IsMatch(employeeDetails.Name, @"(^[a-zA-Z][a-zA-Z\s]{0,20}[a-zA-Z]$)")) throw new ValidationException("Enter valid username");
            if (string.IsNullOrEmpty(employeeDetails.Mailid)) throw new ValidationException("Enter Mailid");
            else if (!Regex.IsMatch(employeeDetails.Mailid, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) throw new ValidationException("Enter Valid Mailid");
            if(string.IsNullOrEmpty(employeeDetails.Address))throw new ValidationException("Enter Address");
            if (employeeDetails.DOB >= DateTime.Now) throw new ValidationException("Enter Valid DOB");
           // if (!Regex.IsMatch(employeeDetails.Genderid, @"^M(ale)?$|^F(emale)?$")) throw new ValidationException("Enter Validate Gender");
           // if(string.IsNullOrEmpty(employeeDetails.Designation))throw new ValidationException("Enter Designation");

        }
    }
}