using Microsoft.EntityFrameworkCore;

namespace Popup_Card_Opration.Models
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
