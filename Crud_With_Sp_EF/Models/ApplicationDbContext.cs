using Microsoft.EntityFrameworkCore;

namespace Crud_With_Sp_EF.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}
