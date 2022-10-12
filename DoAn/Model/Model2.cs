using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.Model
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<BACSI> BACSIs { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHHIEUCHITIETDATLICH> PHHIEUCHITIETDATLICHes { get; set; }
        public virtual DbSet<PHIEUDATLICH> PHIEUDATLICHes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BACSI>()
                .Property(e => e.MABS)
                .IsFixedLength();

            modelBuilder.Entity<BACSI>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACSI>()
                .Property(e => e.MAKHOA)
                .IsFixedLength();

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.MABN)
                .IsFixedLength();

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<KHOA>()
                .Property(e => e.MAKHOA)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MAKHOA)
                .IsFixedLength();

            modelBuilder.Entity<PHHIEUCHITIETDATLICH>()
                .Property(e => e.MAPHIEUCT)
                .IsFixedLength();

            modelBuilder.Entity<PHHIEUCHITIETDATLICH>()
                .Property(e => e.MAPHIEUDL)
                .IsFixedLength();

            modelBuilder.Entity<PHHIEUCHITIETDATLICH>()
                .Property(e => e.MABS)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDATLICH>()
                .Property(e => e.MAPHIEUDL)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDATLICH>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDATLICH>()
                .Property(e => e.MABN)
                .IsFixedLength();
        }
    }
}
