using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recon.Data.Models.Master;

namespace Recon.Data.EntityConfigurations
{
    public class LookUpCategoryEntityConfiguration : IEntityTypeConfiguration<LookupCategory>
    {
        public void Configure(EntityTypeBuilder<LookupCategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(e => e.LookUps)
               .WithOne(e => e.LookUpCategory);
        }
    }
}
