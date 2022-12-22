using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class Designation
    {
        [Key]
        public int id {get;set;}
        public string? name {get;set;}
        public virtual EmployeeDetails? employeeDetails{get;set;}
    }
}