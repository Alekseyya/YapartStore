using System.Data.Entity;
using YapartStore.DL.Entities;

namespace YapartStore.DL.Context
{
    public class YapartStoreContext: DbContext
    {
        public YapartStoreContext() :base ("YapartStore")
        {}

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new SectionConfiguration());
            modelBuilder.Configurations.Add(new BrandConfiguration());            
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
