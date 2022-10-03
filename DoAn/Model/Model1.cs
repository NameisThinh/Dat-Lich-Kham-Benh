using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DangNhap> DangNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangNhap>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.MatKhau)
                .IsFixedLength();
        }
    }
}
