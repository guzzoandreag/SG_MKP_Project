using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SG_MKP_API.Models
{
    public partial class Model_PRODUTO : DbContext
    {
        public Model_PRODUTO()
            : base("name=Model_PRODUTO")
        {
        }

        public virtual DbSet<PRODUTO> PRODUTO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_CATEGORIA)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_CONDICAOPRODUTO)
                .IsUnicode(false);
        }
    }
}
