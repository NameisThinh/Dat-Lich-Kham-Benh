namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHHIEUCHITIETDATLICH")]
    public partial class PHHIEUCHITIETDATLICH
    {
        [Key]
        [StringLength(20)]
        public string MAPHIEUCT { get; set; }

        [StringLength(20)]
        public string MAPHIEUDL { get; set; }

        [StringLength(20)]
        public string MABS { get; set; }

        [StringLength(100)]
        public string CHIDINHKHAM { get; set; }

        public DateTime? NGAYHENKHAM { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        public virtual BACSI BACSI { get; set; }

        public virtual PHIEUDATLICH PHIEUDATLICH { get; set; }
    }
}
