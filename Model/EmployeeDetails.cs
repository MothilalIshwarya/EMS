using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagementSystem.Model
{
    public class EmployeeDetails
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string? Name {get;set;}
        [Required]
        public string? Mailid {get;set;}
        [Required]
        public string? Address {get;set;}
        
        public DateTime DOB {get;set;}
        [Required]
        public string? Gender {get;set;}
        [Required]
        public string? Designation{get;set;}
    }
}