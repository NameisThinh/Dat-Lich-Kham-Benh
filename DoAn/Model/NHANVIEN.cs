namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            PHIEUDATLICHes = new HashSet<PHIEUDATLICH>();
        }

        [Key]
        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(200)]
        public string TENNV { get; set; }

        public int? NAMSINH { get; set; }

        [StringLength(200)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string MATK { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATLICH> PHIEUDATLICHes { get; set; }
    }
}
