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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHAN()
        {
            PHIEUDATLICHes = new HashSet<PHIEUDATLICH>();
        }

        [Key]
        public int MABN { get; set; }

        [Required]
        [StringLength(200)]
        public string TENBN { get; set; }

        public int? NAMSINH { get; set; }

        public bool? GIOITINH { get; set; }

        [Required]
        [StringLength(200)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(200)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATLICH> PHIEUDATLICHes { get; set; }
    }
}
