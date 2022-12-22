using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagementSystem.Model
{
    public class EmployeeDetails
    {
        [Key]
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Mailid { get; set; }
       
        public string? Address { get; set; }

        public DateTime DOB { get; set; }
       
        public int Genderid { get; set; }
       
        public int designationId { get; set; }
        public virtual ICollection<Gender>? gender{get;set;}
        public virtual ICollection<Designation>? Designation{get;set;}

    }
}