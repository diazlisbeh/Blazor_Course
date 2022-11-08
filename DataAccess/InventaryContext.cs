using Microsoft.EntityFrameworkCore;
using Blazor_Course.Entities;
namespace Blazor_Course.DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products {get;set;}
        public DbSet<WherehouseEntity> Wherehouses {get;set;}
        public DbSet<CategoryEntity> Categories {get;set;}
        public DbSet<InputOutputEntity> inOuts {get;set;}
        public DbSet<StorageEntity> Storages{get;set;}

        // public InventaryContext(DbContextOptions options):base( options) {}

        public InventaryContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        if(!options.IsConfigured){
        options.UseMySql("Server=localhost;Database=Inventory;Uid=root;Pwd=password123",ServerVersion.AutoDetect("Server=localhost;Database=Inventory;Uid=root;Pwd=password123"));
        }
        }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryEntity>().HasData(
                new CategoryEntity{CategotyId="ASH", CategoryName="Aseo Hogar"},
                new CategoryEntity{CategotyId="VDI", CategoryName="Video Juegos"},
                new CategoryEntity{CategotyId="TEC", CategoryName="Tecnologies"},
                new CategoryEntity{CategotyId="SCH", CategoryName="Escolares"}
            );

            builder.Entity<WherehouseEntity>().HasData(
                new WherehouseEntity{WherehoueseId= Guid.NewGuid().ToString(),WherehoueseName="Principal"},
                new WherehouseEntity{WherehoueseId= Guid.NewGuid().ToString(),WherehoueseName="Este"},
                new WherehouseEntity{WherehoueseId= Guid.NewGuid().ToString(),WherehoueseName="Oeste"}
            );

        }
    }
}