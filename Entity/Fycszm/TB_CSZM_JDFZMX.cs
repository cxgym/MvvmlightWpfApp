namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_JDFZMX
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string FZQKLSH { get; set; }

        [StringLength(10)]
        public string CSZMBH { get; set; }

        [StringLength(32)]
        public string FZ_JBRID { get; set; }

        [StringLength(2)]
        public string FZ_YY { get; set; }

        [StringLength(100)]
        public string FZ_JBRMC { get; set; }

        [StringLength(11)]
        public string FZ_DJJGCODE { get; set; }

        [StringLength(100)]
        public string FZ_DJJGMC { get; set; }

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
    }
}
