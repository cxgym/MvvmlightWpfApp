namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_KCMX
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string CSZMBH { get; set; }

        public DateTime? RK_RQ { get; set; }

        public DateTime? CK_RQ { get; set; }

        [StringLength(12)]
        public string RK_QXDM { get; set; }

        [StringLength(100)]
        public string RK_QXMC { get; set; }

        [StringLength(50)]
        public string RK_JGCODE { get; set; }

        [StringLength(100)]
        public string RK_JGMC { get; set; }

        [StringLength(50)]
        public string RK_CZRXM { get; set; }

        [StringLength(50)]
        public string RK_CZRID { get; set; }

        [StringLength(2)]
        public string BHZT { get; set; }

        [StringLength(2)]
        public string FZYY { get; set; }

        [StringLength(2)]
        public string QFLX { get; set; }

        [StringLength(100)]
        public string CZRXM { get; set; }

        [StringLength(32)]
        public string CZRID { get; set; }

        [StringLength(100)]
        public string SHRXM { get; set; }

        [StringLength(32)]
        public string SHRID { get; set; }

        [StringLength(100)]
        public string CZJGMC { get; set; }

        [StringLength(11)]
        public string CZJGCODE { get; set; }

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
        public string SDZT { get; set; }
    }
}
