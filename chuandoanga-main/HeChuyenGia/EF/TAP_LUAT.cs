namespace HeChuyenGia.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAP_LUAT
    {
        [Key]
        [StringLength(10)]
        public string MA_LUAT { get; set; }

        [Required]
        [StringLength(100)]
        public string GIA_THIET { get; set; }

        [Required]
        [StringLength(10)]
        public string KET_LUAN { get; set; }
    }
}
