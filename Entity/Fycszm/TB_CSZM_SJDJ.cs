namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_SJDJ
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string SJDJ_LSH { get; set; }

        [Required]
        [StringLength(10)]
        public string CSZMBHFROM { get; set; }

        [Required]
        [StringLength(10)]
        public string CSZMBHTO { get; set; }

        public long? SJNUM { get; set; }

        public DateTime? SJ_RQ { get; set; }

        [StringLength(12)]
        public string SJ_QXCODE { get; set; }

        [StringLength(100)]
        public string SJ_QXMC { get; set; }

        [StringLength(11)]
        public string SJ_JGDM { get; set; }

        [StringLength(100)]
        public string SJ_JGMC { get; set; }

        [StringLength(2)]
        public string BHZT { get; set; }

        [StringLength(32)]
        public string CZRID { get; set; }

        [StringLength(100)]
        public string CZRXM { get; set; }

        [StringLength(200)]
        public string SJBZ { get; set; }

        [StringLength(32)]
        public string SJRKRID { get; set; }

        [StringLength(100)]
        public string SJRKRXM { get; set; }

        public DateTime? SJRKRQ { get; set; }

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
