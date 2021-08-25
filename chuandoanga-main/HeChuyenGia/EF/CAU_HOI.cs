namespace HeChuyenGia.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAU_HOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAU_HOI()
        {
            TRIEU_CHUNG = new HashSet<TRIEU_CHUNG>();
        }

        [Key]
        [StringLength(10)]
        public string MA_CH { get; set; }

        [StringLength(100)]
        public string TEN_CH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIEU_CHUNG> TRIEU_CHUNG { get; set; }
    }
}
