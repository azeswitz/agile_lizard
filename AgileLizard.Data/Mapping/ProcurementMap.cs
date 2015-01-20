using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AgileLizard.Domain;

namespace AgileLizard.Data.Mapping
{
    public class ProcurementMap : EntityTypeConfiguration<Procurement>
    {
        public ProcurementMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcurementId);

            // Properties
            this.Property(t => t.data_type)
                .HasMaxLength(500);

            this.Property(t => t.data_source)
                .HasMaxLength(500);

            this.Property(t => t.notice_type)
                .HasMaxLength(500);

            this.Property(t => t.solnbr)
                .HasMaxLength(500);

            this.Property(t => t.solnbr_ci)
                .HasMaxLength(500);

            this.Property(t => t.id)
                .HasMaxLength(500);

            this.Property(t => t.posted_dt)
                .HasMaxLength(500);

            this.Property(t => t.agency)
                .HasMaxLength(500);

            this.Property(t => t.office)
                .HasMaxLength(500);

            this.Property(t => t.location)
                .HasMaxLength(500);

            this.Property(t => t.zipcode)
                .HasMaxLength(500);

            this.Property(t => t.FBO_CLASSCOD)
                .HasMaxLength(500);

            this.Property(t => t.FBO_NAICS)
                .HasMaxLength(500);

            this.Property(t => t.FBO_OFFADD)
                .HasMaxLength(500);

            this.Property(t => t.title)
                .HasMaxLength(500);

            this.Property(t => t.close_dt)
                .HasMaxLength(500);

            this.Property(t => t.FBO_ARCHDATE_dt)
                .HasMaxLength(500);

            this.Property(t => t.FBO_CONTACT)
                .HasMaxLength(500);

            this.Property(t => t.listing_url)
                .HasMaxLength(500);

            this.Property(t => t.FBO_EMAIL_ADDRESS)
                .HasMaxLength(500);

            this.Property(t => t.FBO_EMAIL_DESC)
                .HasMaxLength(500);

            this.Property(t => t.FBO_SETASIDE)
                .HasMaxLength(500);

            this.Property(t => t.FBO_POPCOUNTRY)
                .HasMaxLength(500);

            this.Property(t => t.FBO_POPZIP)
                .HasMaxLength(500);

            this.Property(t => t.FBO_POPADDRESS)
                .HasMaxLength(500);

            this.Property(t => t.version)
                .HasMaxLength(500);

            this.Property(t => t.score)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Procurement");
            this.Property(t => t.ProcurementId).HasColumnName("ProcurementId");
            this.Property(t => t.data_type).HasColumnName("data_type");
            this.Property(t => t.data_source).HasColumnName("data_source");
            this.Property(t => t.notice_type).HasColumnName("notice_type");
            this.Property(t => t.solnbr).HasColumnName("solnbr");
            this.Property(t => t.solnbr_ci).HasColumnName("solnbr_ci");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.posted_dt).HasColumnName("posted_dt");
            this.Property(t => t.agency).HasColumnName("agency");
            this.Property(t => t.office).HasColumnName("office");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.zipcode).HasColumnName("zipcode");
            this.Property(t => t.FBO_CLASSCOD).HasColumnName("FBO_CLASSCOD");
            this.Property(t => t.FBO_NAICS).HasColumnName("FBO_NAICS");
            this.Property(t => t.FBO_OFFADD).HasColumnName("FBO_OFFADD");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.close_dt).HasColumnName("close_dt");
            this.Property(t => t.FBO_ARCHDATE_dt).HasColumnName("FBO_ARCHDATE_dt");
            this.Property(t => t.FBO_CONTACT).HasColumnName("FBO_CONTACT");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.listing_url).HasColumnName("listing_url");
            this.Property(t => t.FBO_EMAIL_ADDRESS).HasColumnName("FBO_EMAIL_ADDRESS");
            this.Property(t => t.FBO_EMAIL_DESC).HasColumnName("FBO_EMAIL_DESC");
            this.Property(t => t.FBO_SETASIDE).HasColumnName("FBO_SETASIDE");
            this.Property(t => t.FBO_POPCOUNTRY).HasColumnName("FBO_POPCOUNTRY");
            this.Property(t => t.FBO_POPZIP).HasColumnName("FBO_POPZIP");
            this.Property(t => t.FBO_POPADDRESS).HasColumnName("FBO_POPADDRESS");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.score).HasColumnName("score");
        }
    }
}
