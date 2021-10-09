
// Nhập appsetting để setting
"ConnectionStrings": {
    "connect":"Data Source=DESKTOP-UE12GR7;Initial Catalog=Planet;Integrated Security=True"
  }

// Tạo file AppDBContext
  namespace aspmvc_hello.Models
{
    public class AppDBContext: DbContext{
        PlanetModel planet;
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

        public DbSet<PlanetModel> planetModels{get; set;}
    }
}

// Add vào Startup
  services.AddDbContext<AppDBContext>(option=>
            {
                string connect=Configuration.GetConnectionString("connect");
                option.UseSqlServer(connect);
            }
            );

// cÁC THAO TÁC CƠ BẢN
    // connect db
    var connect=dbConext.Database.GetDbConnection();
    // lấy tên db
    var dbname=connect.Database;
    // Check connect đc k: result fasle or true
    var can_connect=dbConext.Database.CanConnect();
    // Lấy datasource
    connect.DataSource
    // status connect
    connect.State;
    // Tìm migrations pen
    @dbConext.Database.GetPendingMigrations())
    // Tìm migrations apply
    dbConext.Database.GetAppliedMigrations())
    // Open db
    await dbConext.Database.OpenConnectionAsync();
    // lấy bảng
    var table= connect.GetSchema("Tables");
    // lấy tên bảng
    foreach (System.Data.DataRow row in table.Rows)
    {
        <p>Name table: @row["TABLE_NAME"]</p>
    }
