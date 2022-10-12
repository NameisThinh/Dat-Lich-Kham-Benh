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
        [Key]
        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(100)]
        public string TENNV { get; set; }

        public int? NAMSINH { get; set; }

        [StringLength(150)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string MAKHOA { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        public virtual KHOA KHOA { get; set; }
    }
}
