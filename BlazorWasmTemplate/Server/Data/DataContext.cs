using Microsoft.EntityFrameworkCore;

namespace BlazorWasmTemplate.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //public DbSet<User> Users { get; set; }
    }
}
