using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class Gender
    {
        [Key]
        public int id{get;set;}
        public string? gender{get;set;}
        public virtual ICollection<EmployeeDetails>? EmployeeDetails{get;set;}
    }
}