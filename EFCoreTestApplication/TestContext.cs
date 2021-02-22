using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreTestApplication
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }
        
        public DbSet<Owner> Owner { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Owner>(ConfigureOwner);
        }

        void ConfigureOwner(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(b => b.Id);
            
            builder.Property(b => b.Name);

            builder.OwnsMany(b => b.OwnedObjects, ownedObject =>
            {
                ownedObject.HasKey(b => b.Id);
                
                ownedObject.Property(b => b.Description);
            });
        }
    }
}
