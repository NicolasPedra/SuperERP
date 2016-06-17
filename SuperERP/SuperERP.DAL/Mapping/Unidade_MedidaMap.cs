using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Models.Mapping
{
    public class Unidade_MedidaMap : EntityTypeConfiguration<Unidade_Medida>
    {
        public Unidade_MedidaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Unidade_Medida");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
