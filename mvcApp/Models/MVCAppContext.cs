using Microsoft.EntityFrameworkCore;

namespace mvcApp.Models
{
    public class MVCAppContext: DbContext
    {
        public MVCAppContext(DbContextOptions<MVCAppContext> options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
