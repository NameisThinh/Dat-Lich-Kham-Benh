namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BACSI")]
    public partial class BACSI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BACSI()
        {
            PHHIEUCHITIETDATLICHes = new HashSet<PHHIEUCHITIETDATLICH>();
        }

        [Key]
        [StringLength(20)]
        public string MABS { get; set; }

        [StringLength(100)]
        public string TENBS { get; set; }

        public int? NAMSINH { get; set; }

        [StringLength(150)]
        public string DIACHI { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string HOCHAM { get; set; }

        [StringLength(20)]
        public string MAKHOA { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHHIEUCHITIETDATLICH> PHHIEUCHITIETDATLICHes { get; set; }
    }
}
