namespace GGW.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GGWdbContext : DbContext
    {
        public GGWdbContext()
            : base("name=GGWdbContext")
        {
        }

        public virtual DbSet<adminM> adminM { get; set; }
        public virtual DbSet<II> II { get; set; }
        public virtual DbSet<news> news { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<adminM>()
                .Property(e => e.adminName)
                .IsUnicode(false);

            modelBuilder.Entity<adminM>()
                .Property(e => e.adminPwd)
                .IsUnicode(false);

            modelBuilder.Entity<II>()
                .Property(e => e.imgLL)
                .IsUnicode(false);

            modelBuilder.Entity<II>()
                .Property(e => e.title)
                .IsUnicode(false);
        }
    }
}
