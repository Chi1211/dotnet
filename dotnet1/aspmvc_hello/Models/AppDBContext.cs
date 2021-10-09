using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace aspmvc_hello.Models
{
    public class AppDBContext: DbContext{
        
        ILogger<AppDBContext> _logger;
        public AppDBContext(DbContextOptions<AppDBContext> options, ILogger<AppDBContext> logger): base(options)
        {
            _logger=logger;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

         public DbSet<ContactModel> contactModels{get; set;}
    }
}