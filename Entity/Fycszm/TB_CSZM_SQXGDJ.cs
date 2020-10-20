namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_SQXGDJ
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string SQXGLSH { get; set; }

        [Required]
        [StringLength(64)]
        public string XSE_NO { get; set; }

        [StringLength(32)]
        public string SQRID { get; set; }

        [StringLength(100)]
        public string SQRXM { get; set; }

        public DateTime? SQSJ { get; set; }

        [StringLength(1000)]
        public string SQXGNR { get; set; }

        [StringLength(32)]
        public string XGZID { get; set; }

        [StringLength(100)]
        public string XGZXM { get; set; }

        public DateTime? XGSJ { get; set; }

        [StringLength(2)]
        public string XGZT { get; set; }

        [StringLength(11)]
        public string SQJGDM { get; set; }

        [StringLength(100)]
        public string SQJGMC { get; set; }

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
