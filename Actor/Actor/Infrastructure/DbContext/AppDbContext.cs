using Actor.Infrastructure.Entities;
using Actor.Infrastructure.Enum;
using Microsoft.EntityFrameworkCore;

namespace Actor.Infrastructure.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Wallet> Wallets { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Entities.Actor> Actors { get; set; }
    public virtual DbSet<Notification> Notifications { get; set; }
    public virtual DbSet<Director> Directors { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Post> Posts { get; set; }
    public virtual DbSet<Entities.Application> Applications { get; set; }
    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role() { Id = 1, RoleName = "Admin" },
            new Role() { Id = 2, RoleName = "Actor" },
            new Role() { Id = 3, RoleName = "Director" }
        );

        modelBuilder.Entity<Wallet>().HasData(
            new Wallet() { Id = 1, Money = 1000000 }
        );

        modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = 1, UserName = "Admin", PhoneNumber = "0397528860", Email = "admin@gmail.com",
                Gender = GenderType.Male, CreateDate = DateTime.Now, Status = UserStatus.Approved, RoleId = 1,
                WalletId = 1, Password = "12345"
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category() { Id = 1, CategoryName = "Main Actor" },
            new Category() { Id = 2, CategoryName = "Support Actor" },
            new Category() { Id = 3, CategoryName = "Other" }
        );
    }
}