namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [Key]
        [StringLength(20)]
        public string MABN { get; set; }

        [StringLength(100)]
        public string TENBN { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        public int? NAMSINH { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(150)]
        public string DIACHI { get; set; }

        public string GHICHU { get; set; }

        public DateTime? NGAYDAT { get; set; }
    }
}
