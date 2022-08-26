using Microsoft.EntityFrameworkCore;
using WebApplication_inlämningsuppgift.Models;

namespace WebApplication_inlämningsuppgift.Data
{
    public class SqlContext: DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> _options):base(_options)
        {
               
        }
        public SqlContext()
        {
                
        }
        public virtual DbSet<User> Users { get; set; } = null!;
    }

}
