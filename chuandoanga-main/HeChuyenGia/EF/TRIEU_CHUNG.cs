namespace HeChuyenGia.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIEU_CHUNG
    {
        [Key]
        [StringLength(10)]
        public string MA_TT { get; set; }

        [StringLength(100)]
        public string TEN_TT { get; set; }

        public int? ID_CAUHOI { get; set; }

        public virtual CAU_HOI CAU_HOI { get; set; }
    }
}
