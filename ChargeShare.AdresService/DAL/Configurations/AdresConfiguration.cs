using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Models;

namespace ChargeShare.AdresService.DAL.Configurations;

public class AdresConfiguration : IEntityTypeConfiguration<AdresModel>
{
    public void Configure(EntityTypeBuilder<AdresModel> builder)
    {
        builder.HasKey(x => x.Id);
    }
}