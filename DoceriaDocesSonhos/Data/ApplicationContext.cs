using DoceriaDocesSonhos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoceriaDocesSonhos.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Product>()
                .ToTable("PRODUTOS");
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("VARCHAR(120)")
                .IsRequired();
            
            modelBuilder.Entity<Product>()
                .Property(p => p.Preco)
                .IsRequired()
                .HasColumnName("PRECO");
            
            modelBuilder.Entity<Product>()
                .Property(p => p.QuantidadeDisponivel)
                .HasColumnName("QUANTIDADE_DISPONIVEL")
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.TipoDeDoce)
                .HasColumnName("TIPO_DE_DOCE");

        }
        public DbSet<Product> produtos { get; set; }

    }
}
