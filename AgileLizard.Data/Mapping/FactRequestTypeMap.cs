using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AgileLizard.Domain;

namespace AgileLizard.Data.Mapping
{
    public class FactRequestTypeMap : EntityTypeConfiguration<FactRequestType>
    {
        public FactRequestTypeMap()
        {
            this.HasKey(t => t.FactId);
            // Properties
            // Table & Column Mappings
            this.ToTable("FactRequestType");
            this.Property(t => t.FactId).HasColumnName("FactId");
            this.Property(t => t.FactName).HasColumnName("FactName");
            this.Property(t => t.FboName).HasColumnName("FboName");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
        }
    }
}
