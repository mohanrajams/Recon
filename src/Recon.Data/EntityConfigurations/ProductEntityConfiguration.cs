using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recon.Data.Models.Master;

namespace Recon.Data.EntityConfigurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(e => e.Provider)
               .WithMany(e => e.Products)
               .HasForeignKey(e => e.ProviderId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
