using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SG_MKP_API.Models
{
    public partial class Model_USUARIO : DbContext
    {
        public Model_USUARIO()
            : base("name=Model_USUARIO")
        {
        }

        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USU_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USU_SENHA)
                .IsUnicode(false);
        }
    }
}
