using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class EMScontext:DbContext
    {
        public EMScontext(DbContextOptions options):base(options){

        }
        public DbSet<EmployeeDetails>EmployeeDetails{get;set;}
        public DbSet<Gender>genders{get;set;}
        public DbSet<Designation>designations{get;set;}
        
    }
    
}

