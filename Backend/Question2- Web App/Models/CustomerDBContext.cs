using Microsoft.EntityFrameworkCore;

namespace Question2__Web_App.Models
{
    public class CustomerDBContext: DbContext
    {
        public CustomerDBContext(DbContextOptions options): base(options) 
        {
            
        }
        public DbSet <Customer> Customers { get; set; }
    }
}
