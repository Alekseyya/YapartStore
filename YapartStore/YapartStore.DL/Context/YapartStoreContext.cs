using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using YapartStore.DL.Entities;
using YapartStore.DL.Entities.Identity;

namespace YapartStore.DL.Context
{
    public class YapartStoreContext: IdentityDbContext<User, CustomRole, Guid, Login, Role, Claim>
    {
        public YapartStoreContext() :base ("YapartStore")
        {}

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new SectionConfiguration());
            modelBuilder.Configurations.Add(new BrandConfiguration());
            modelBuilder.Configurations.Add(new PictureConfiguration());

            modelBuilder.Configurations.Add(new ClaimConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderItemConfiguration());
        }
        public class DatabaseInitializer
            : CreateDatabaseIfNotExists<YapartStoreContext>
        {
            public override void InitializeDatabase(YapartStoreContext context)
            {

            }
        }
    }
}
