using System.Data.Entity;
using Business.Model;
using Business.Data.Access.Configuration;

namespace Business.Data
{
    public class Context : DbContext
    {
        public Context() : base("Name=Assignment")
        {
        }
        public DbSet<CITATION> citation { get; set; }
        public DbSet<TBL_COUNTRY> country { get; set; }
        public DbSet<ORDER_WAREHOUSE> order_warehouse { get; set; }
        public DbSet<REFERENCES> references { get; set; }
        public DbSet<REGISTRATION> registration { get; set; }
        public DbSet<HOW_YOU_KNOW> how_you_know { get; set; }
        public DbSet<LANGUAGE> languages { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderConfig());
            modelBuilder.Configurations.Add(new CountryConfig());
            modelBuilder.Configurations.Add(new CitConfig());
            modelBuilder.Configurations.Add(new ReferenceConfig());
            modelBuilder.Configurations.Add(new RegistationConfig());
            modelBuilder.Configurations.Add(new HowYouKnowConfig());
            modelBuilder.Configurations.Add(new LanguageConfig());
        }
    }
}