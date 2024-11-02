using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recon.Data.Models.Master;

namespace Recon.Data.EntityConfigurations
{
    public class ProviderEntityConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(e => e.Products)
               .WithOne(e => e.Provider);
        }
    }
}
