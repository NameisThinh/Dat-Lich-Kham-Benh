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
            PHHIEUCHITIETDATLICHes = new HashSet<PHHIEUCHITIETDATLICH>();
        }

        [Key]
        [StringLength(20)]
        public string MAPHIEUDL { get; set; }

        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(20)]
        public string MABN { get; set; }

        public DateTime? NGAYLAPPHIEU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHHIEUCHITIETDATLICH> PHHIEUCHITIETDATLICHes { get; set; }
    }
}
