using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AgileLizard.Domain;

namespace AgileLizard.Data.Mapping
{
    public class FboProfileMap : EntityTypeConfiguration<FboProfile>
    {
        public FboProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.FboProfileId);
            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.MiddleName)
                .HasMaxLength(500);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.BusinessType)
                .HasMaxLength(500);

            // Properties
            // Table & Column Mappings
            this.ToTable("FboProfile");
            this.Property(t => t.FboProfileId).HasColumnName("FboProfileId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.PersonImage).HasColumnName("PersonImage");
            this.Property(t => t.PersonBlurb).HasColumnName("PersonBlurb");
            this.Property(t => t.BusinessType).HasColumnName("BusinessType");
            this.Property(t => t.BusinessLogo).HasColumnName("BusinessLogo");
            this.Property(t => t.BusinessBlurb).HasColumnName("BusinessBlurb");
            this.Property(t => t.CapabilityBlurb).HasColumnName("CapabilityBlurb");
            this.Property(t => t.OtherInterestBlurb).HasColumnName("OtherInterestBlurb");
        }
    }
}
