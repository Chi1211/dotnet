using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace asprazor06{
public class NewsDBContext: IdentityDbContext<User>{
    public NewsDBContext(DbContextOptions<NewsDBContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        foreach(var identityType in modelBuilder.Model.GetEntityTypes())
        {
            var tableName=identityType.GetTableName();
            if(tableName.StartsWith("AspNet"))
            {
                identityType.SetTableName(tableName.Substring(6));
            }
        }
    }

    public DbSet<Article> articles{  get; set;}
}
}