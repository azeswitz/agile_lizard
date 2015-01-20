using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AgileLizard.Domain;

namespace AgileLizard.Data.Mapping
{
    public class HighlightMap : EntityTypeConfiguration<Highlight>
    {
        public HighlightMap()
        {
            // Primary Key
            this.HasKey(t => t.HighlightsId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Highlights");
            this.Property(t => t.HighlightsId).HasColumnName("HighlightsId");
            this.Property(t => t.ProcurementId).HasColumnName("ProcurementId");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
