namespace HeChuyenGia.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BENH_GA
    {
        [Key]
        [StringLength(10)]
        public string MA_BENH { get; set; }

        [Required]
        [StringLength(100)]
        public string MO_TA { get; set; }
    }
}
