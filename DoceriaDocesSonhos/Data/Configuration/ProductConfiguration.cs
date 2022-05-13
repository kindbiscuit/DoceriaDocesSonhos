using DoceriaDocesSonhos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUTOS");
           
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("VARCHAR(120)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnName("PRECO");

            builder.Property(p => p.QuantidadeDisponivel)
                .HasColumnName("QUANTIDADE_DISPONIVEL")
                .IsRequired();

            builder
                .Property(p => p.TipoDeDoce)
                .HasColumnName("TIPO_DE_DOCE");
        }
    }
}
