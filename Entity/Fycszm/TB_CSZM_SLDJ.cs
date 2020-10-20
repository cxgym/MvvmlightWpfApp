namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_SLDJ
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string SLDJ_LSH { get; set; }

        [StringLength(12)]
        public string SL_QXCODE { get; set; }

        [StringLength(100)]
        public string SL_QXMC { get; set; }

        public DateTime? SL_RQ { get; set; }

        [StringLength(11)]
        public string SL_JGCODE { get; set; }

        [StringLength(100)]
        public string SL_JGMC { get; set; }

        [StringLength(32)]
        public string SLRID { get; set; }

        [StringLength(100)]
        public string SLRXM { get; set; }

        public long? SL_SL { get; set; }

        [StringLength(200)]
        public string SL_YY { get; set; }

        public long? SJXF_SL { get; set; }

        [StringLength(10)]
        public string SLZT { get; set; }

        [StringLength(1000)]
        public string YL1 { get; set; }

        [StringLength(1000)]
        public string YL2 { get; set; }

        [StringLength(1000)]
        public string YL3 { get; set; }

        [Required]
        [StringLength(1)]
        public string X_CHANGE { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATE_BY { get; set; }

        public DateTime CREATE_DATE { get; set; }

        [Required]
        [StringLength(64)]
        public string UPDATE_BY { get; set; }

        public DateTime UPDATE_DATE { get; set; }

        [StringLength(255)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(1)]
        public string DEL_FLAG { get; set; }
    }
}
