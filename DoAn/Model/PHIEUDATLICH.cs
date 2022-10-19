namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDATLICH")]
    public partial class PHIEUDATLICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATLICH()
        {
            CTPHIEUDATLICHes = new HashSet<CTPHIEUDATLICH>();
        }

        [Key]
        public int MAPHIEUDL { get; set; }

        public DateTime? NGAYLAPPHIEU { get; set; }

        [StringLength(20)]
        public string MANV { get; set; }

        public int? MABN { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPHIEUDATLICH> CTPHIEUDATLICHes { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
