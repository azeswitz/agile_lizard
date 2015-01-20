using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AgileLizard.Domain;

namespace AgileLizard.Data.Mapping
{
    public class DemoMap : EntityTypeConfiguration<Demo>
    {
        public DemoMap()
        {
            // Primary Key
            this.HasKey(t => t.DemoId);

            // Properties
            this.Property(t => t.ColumnOne)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Demo");
            this.Property(t => t.DemoId).HasColumnName("DemoId");
            this.Property(t => t.ColumnOne).HasColumnName("ColumnOne");
        }
    }
}
