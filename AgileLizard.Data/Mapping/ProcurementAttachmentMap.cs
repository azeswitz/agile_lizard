using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AgileLizard.Domain;

namespace AgileLizard.Data.Mapping
{
    public class ProcurementAttachmentMap : EntityTypeConfiguration<ProcurementAttachment>
    {
        public ProcurementAttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcurementAttachmentId);

            // Properties
            this.Property(t => t.SystemPath)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ProcurementAttachment");
            this.Property(t => t.ProcurementAttachmentId).HasColumnName("ProcurementAttachmentId");
            this.Property(t => t.ProcurmentId).HasColumnName("ProcurmentId");
            this.Property(t => t.SystemPath).HasColumnName("SystemPath");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");

            // Relationships
            this.HasOptional(t => t.Procurement)
                .WithMany(t => t.ProcurementAttachments)
                .HasForeignKey(d => d.ProcurmentId);

        }
    }
}
