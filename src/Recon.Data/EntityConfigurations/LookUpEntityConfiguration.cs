using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recon.Data.Models.Master;

namespace Recon.Data.EntityConfigurations
{
    public class LookUpEntityConfiguration : IEntityTypeConfiguration<LookUp>
    {
        public void Configure(EntityTypeBuilder<LookUp> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(e => e.LookUpCategory)
               .WithMany(e => e.LookUps)
               .HasForeignKey(e => e.LookUpCategoryId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
