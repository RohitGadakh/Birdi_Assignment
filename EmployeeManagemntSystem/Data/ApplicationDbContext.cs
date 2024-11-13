
using EmployeeManagemntSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagemntSystem.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    
        public DbSet<Employee> Employees { get; set; } 
    
    }
}
