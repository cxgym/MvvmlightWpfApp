namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_FZDJ
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string FZDJ_LSH { get; set; }

        public DateTime? FZ_RQ { get; set; }

        [StringLength(64)]
        public string FZ_QSBH { get; set; }

        [StringLength(64)]
        public string FZ_ZZBH { get; set; }

        public long? FZ_SL { get; set; }

        [StringLength(2)]
        public string FZ_YY { get; set; }

        [StringLength(100)]
        public string FZ_QTYY { get; set; }

        [StringLength(32)]
        public string FZ_JBRID { get; set; }

        [StringLength(100)]
        public string FZ_JBRMC { get; set; }

        [StringLength(11)]
        public string FZ_DJJGCODE { get; set; }

        [StringLength(100)]
        public string FZ_DJJGMC { get; set; }

        [StringLength(32)]
        public string FZ_QJSHRID { get; set; }

        [StringLength(100)]
        public string FZ_QJSHRMC { get; set; }

        public DateTime? FZ_QJSHRQ { get; set; }

        [StringLength(11)]
        public string FZ_QJSHJGCODE { get; set; }

        [StringLength(100)]
        public string FZ_QJSHJGMC { get; set; }

        [StringLength(400)]
        public string FZ_QJSHBTGYY { get; set; }

        [StringLength(32)]
        public string FZ_SJSHRID { get; set; }

        [StringLength(100)]
        public string FZ_SJSHRMC { get; set; }

        public DateTime? FZ_SJSHRQ { get; set; }

        [StringLength(11)]
        public string FZ_SJSHJGCODE { get; set; }

        [StringLength(100)]
        public string FZ_SJSHJGMC { get; set; }

        [StringLength(400)]
        public string FZ_SJSHBTGYY { get; set; }

        [StringLength(2)]
        public string FZ_SHZT { get; set; }

        [StringLength(12)]
        public string FZ_DJQX { get; set; }

        [StringLength(100)]
        public string FZ_DJQXMC { get; set; }

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

        [StringLength(2)]
        public string LXBS { get; set; }

        public DateTime? SCSJ { get; set; }
    }
}
