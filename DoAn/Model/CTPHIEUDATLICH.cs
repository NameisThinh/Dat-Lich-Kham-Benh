namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPHIEUDATLICH")]
    public partial class CTPHIEUDATLICH
    {
        [Key]
        [Column(Order = 0)]
<<<<<<< HEAD
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPHIEUDL { get; set; }
=======
=======
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79
        [StringLength(20)]
        public string MAPHIEUDL { get; set; }
>>>>>>> 03eb0f6d6677e584d919bbd226141ceaf447ad79

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MABS { get; set; }

        [StringLength(100)]
        public string DAKHAMTAI { get; set; }

        [StringLength(200)]
        public string LYDO { get; set; }

        public bool? TINHTRANG { get; set; }

        public virtual BACSI BACSI { get; set; }

        public virtual PHIEUDATLICH PHIEUDATLICH { get; set; }
    }
}
