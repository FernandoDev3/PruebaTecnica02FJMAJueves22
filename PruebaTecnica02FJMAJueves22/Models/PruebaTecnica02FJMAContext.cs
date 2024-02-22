using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PruebaTecnica02FJMAJueves22.Models;

namespace PruebaTecnica02FJMAJueves22.Models
{
    public partial class PruebaTecnica02FJMAContext : DbContext
    {
        public PruebaTecnica02FJMAContext()
        {
        }

        public PruebaTecnica02FJMAContext(DbContextOptions<PruebaTecnica02FJMAContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9JIAMII;Initial Catalog=PruebaTecnica02FJMA;Integrated Security=True;Trust Server Certificate=True");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<PruebaTecnica02FJMAJueves22.Models.Marcas>? Marcas { get; set; }
    }
}
