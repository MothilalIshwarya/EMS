using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagementSystem.Model
{
    public class EmployeeDetails
    {
        [Key]
        public int Id {get;set;}
        public string? Name {get;set;}
        public string? Mailid {get;set;}
        public string? Address {get;set;}
        public DateTime DOB {get;set;}
        public string? Gender {get;set;}
        public string? Designation{get;set;}
    }
}