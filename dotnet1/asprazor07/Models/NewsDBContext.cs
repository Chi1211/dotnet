using Microsoft.EntityFrameworkCore;

public class NewsDBContext: DbContext{
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
    }

    public DbSet<Article> articles{  get; set;}
}