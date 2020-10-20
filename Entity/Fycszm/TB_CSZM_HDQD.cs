namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_HDQD
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string HDQDLSH { get; set; }

        [StringLength(4)]
        public string NF { get; set; }

        [StringLength(1)]
        public string JD { get; set; }

        public DateTime? HD_RQ { get; set; }

        [StringLength(12)]
        public string HD_QXCODE { get; set; }

        [StringLength(100)]
        public string HD_QXMC { get; set; }

        [StringLength(100)]
        public string HDFZRXM { get; set; }

        [StringLength(2)]
        public string HDZT { get; set; }

        [StringLength(11)]
        public string HDCZJQCODE { get; set; }

        [StringLength(100)]
        public string HDCZJQMC { get; set; }

        [StringLength(32)]
        public string HDCZRID { get; set; }

        [StringLength(100)]
        public string HDCZRXM { get; set; }

        public DateTime? SB_RQ { get; set; }

        [StringLength(32)]
        public string SJSHRID { get; set; }

        [StringLength(100)]
        public string SJSHRMC { get; set; }

        public DateTime? SJSHRQ { get; set; }

        [StringLength(11)]
        public string SJSHJGCODE { get; set; }

        [StringLength(100)]
        public string SJSHJGMC { get; set; }

        [StringLength(400)]
        public string SJSHBTGYY { get; set; }

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
