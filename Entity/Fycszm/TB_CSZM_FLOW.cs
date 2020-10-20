namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_FLOW
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string LSH { get; set; }

        [StringLength(64)]
        public string XSE_NO { get; set; }

        [StringLength(64)]
        public string CSZMBH { get; set; }

        public DateTime? CZRQ { get; set; }

        [StringLength(32)]
        public string CZRID { get; set; }

        [StringLength(100)]
        public string CZRXM { get; set; }

        [StringLength(11)]
        public string CZJGCODE { get; set; }

        [StringLength(100)]
        public string CZJGMC { get; set; }

        [StringLength(32)]
        public string CZYM { get; set; }

        [StringLength(32)]
        public string CZAN { get; set; }

        [StringLength(255)]
        public string CZNR { get; set; }

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
