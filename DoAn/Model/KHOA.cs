namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOA")]
    public partial class KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA()
        {
            BACSIs = new HashSet<BACSI>();
        }

        [Key]
        [StringLength(20)]
        public string MAKHOA { get; set; }

        [StringLength(200)]
        public string TENKHOA { get; set; }

        [StringLength(200)]
        public string CHUYENMON { get; set; }

        public int? SLBACSI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BACSI> BACSIs { get; set; }
    }
}
