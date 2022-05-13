using DoceriaDocesSonhos.Data.Configuration;
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
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
        public DbSet<Product> produtos { get; set; }

    }
}
