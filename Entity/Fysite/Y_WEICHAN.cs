namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Y_WEICHAN
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string YID { get; set; }

        [Required]
        [StringLength(10)]
        public string BIRTHORDER { get; set; }

        [Required]
        [StringLength(10)]
        public string XB { get; set; }

        public DateTime CSRQ { get; set; }

        public decimal TZ { get; set; }

        public decimal TC { get; set; }

        [Required]
        [StringLength(10)]
        public string TFW { get; set; }

        [Required]
        [StringLength(64)]
        public string XSEJB { get; set; }

        [StringLength(32)]
        public string JBSCJJ { get; set; }

        [StringLength(32)]
        public string JBSCBB { get; set; }

        [StringLength(10)]
        public string SSXPZZSZ { get; set; }

        [StringLength(10)]
        public string BJJBSC { get; set; }

        [StringLength(32)]
        public string SSCR { get; set; }

        [StringLength(32)]
        public string TLSCZE { get; set; }

        [StringLength(32)]
        public string TLSCYE { get; set; }

        [StringLength(32)]
        public string TLSCR { get; set; }

        [Required]
        [StringLength(32)]
        public string ZK { get; set; }

        [Required]
        [StringLength(10)]
        public string CSQX { get; set; }

        [StringLength(10)]
        public string XSESW { get; set; }

        [Required]
        [StringLength(32)]
        public string APGAR1 { get; set; }

        [Required]
        [StringLength(32)]
        public string APGAR2 { get; set; }

        [Required]
        [StringLength(32)]
        public string APGAR3 { get; set; }

        [StringLength(64)]
        public string WCEXM { get; set; }

        [StringLength(64)]
        public string CSYXZMBH { get; set; }

        [StringLength(32)]
        public string XXSC { get; set; }

        [StringLength(32)]
        public string XZSCR { get; set; }

        [StringLength(10)]
        public string ISSJA { get; set; }

        [StringLength(10)]
        public string ISSJE { get; set; }

        [StringLength(255)]
        public string SWYY { get; set; }

        [StringLength(1000)]
        public string JTJG { get; set; }

        [StringLength(32)]
        public string CXTXM { get; set; }

        [StringLength(32)]
        public string CXSCR { get; set; }

        public DateTime? ZZRQ { get; set; }

        [StringLength(32)]
        public string WZLRR { get; set; }

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

        [StringLength(510)]
        public string REMARKS { get; set; }

        [Required]
        [StringLength(1)]
        public string DEL_FLAG { get; set; }

        [StringLength(18)]
        public string XSE_NO { get; set; }

        [StringLength(200)]
        public string XSEJBQT { get; set; }
    }
}
