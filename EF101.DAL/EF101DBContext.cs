using EF101.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF101.DAL
{
    public class EF101DBContext : DbContext
    {
        public EF101DBContext()
            : base("name=EF101DBContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Disable Pluralizing Convention if needed
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // https://msdn.microsoft.com/library/system.data.entity.modelconfiguration.conventions.aspx

            // Implement specific model to database configuration if needed
            // https://msdn.microsoft.com/en-us/library/jj819164(v=vs.113).aspx

            // modelBuilder.Configurations.Add(new EntityTypeConfiguration<Movie>().HasKey(e => e.MovieKey));

        }
    }
}
