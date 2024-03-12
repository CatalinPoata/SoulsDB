using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoulsDB.Data.Entities;

namespace SoulsDB.Data.EntityConfigs
{
    public class NormWeapReinfMultipliersConfiguration : IEntityTypeConfiguration<NormWeapReinfMultiplier>
    {
        public void Configure(EntityTypeBuilder<NormWeapReinfMultiplier> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
