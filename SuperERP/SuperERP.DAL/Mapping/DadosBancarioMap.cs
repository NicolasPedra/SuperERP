using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Models.Mapping
{
    public class DadosBancarioMap : EntityTypeConfiguration<DadosBancario>
    {
        public DadosBancarioMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Banco)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Conta_Corrente)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Agencia)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DadosBancarios");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Banco).HasColumnName("Banco");
            this.Property(t => t.Conta_Corrente).HasColumnName("Conta_Corrente");
            this.Property(t => t.Agencia).HasColumnName("Agencia");
            this.Property(t => t.ID_PessoaJuridica).HasColumnName("ID_PessoaJuridica");
            this.Property(t => t.ID_PessoaFisica).HasColumnName("ID_PessoaFisica");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");

            // Relationships
            this.HasOptional(t => t.Empresa)
                .WithMany(t => t.DadosBancarios)
                .HasForeignKey(d => d.ID_Empresa);
            this.HasOptional(t => t.PessoaFisica)
                .WithMany(t => t.DadosBancarios)
                .HasForeignKey(d => d.ID_PessoaFisica);
            this.HasOptional(t => t.PessoaJuridica)
                .WithMany(t => t.DadosBancarios)
                .HasForeignKey(d => d.ID_PessoaJuridica);

        }
    }
}
