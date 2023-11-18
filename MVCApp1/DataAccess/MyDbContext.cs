using Microsoft.EntityFrameworkCore;
using Entity;

namespace MVCApp1.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; } 

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}
