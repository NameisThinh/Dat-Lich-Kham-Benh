using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.Model
{
    public partial class Model1 : DbContext
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<<< HEAD:DoAn/Model/Model1.cs
        public Model1()
========
        public Model2()
<<<<<<<< HEAD:DoAn/Model/Model1.cs
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
        public Model1()
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
========
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
        public Model1()
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
            : base("name=Model1")
        {
        }

        public virtual DbSet<BACSI> BACSIs { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }
        public virtual DbSet<CTPHIEUDATLICH> CTPHIEUDATLICHes { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUDATLICH> PHIEUDATLICHes { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

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

            modelBuilder.Entity<BACSI>()
                .HasMany(e => e.CTPHIEUDATLICHes)
                .WithRequired(e => e.BACSI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTPHIEUDATLICH>()
<<<<<<< HEAD
<<<<<<<< HEAD:DoAn/Model/Model1.cs
<<<<<<< HEAD
<<<<<<<< HEAD:DoAn/Model/Model1.cs
========
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
========
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
                .Property(e => e.MAPHIEUDL)
                .IsFixedLength();

            modelBuilder.Entity<CTPHIEUDATLICH>()
<<<<<<< HEAD
<<<<<<<< HEAD:DoAn/Model/Model1.cs
<<<<<<< HEAD
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
========
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
                .Property(e => e.MABS)
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
                .Property(e => e.MATK)
<<<<<<< HEAD
<<<<<<<< HEAD:DoAn/Model/Model1.cs
<<<<<<< HEAD
<<<<<<<< HEAD:DoAn/Model/Model1.cs
========
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
========
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDATLICH>()
                .Property(e => e.MAPHIEUDL)
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79:DoAn/Model/Model2.cs
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDATLICH>()
                .Property(e => e.MANV)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUDATLICH>()
                .HasMany(e => e.CTPHIEUDATLICHes)
                .WithRequired(e => e.PHIEUDATLICH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATK)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TENDANGNHAP)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATKHAU)
                .IsFixedLength();
        }
    }
}
