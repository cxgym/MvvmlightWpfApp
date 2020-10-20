namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_GBZCJG
    {
        [StringLength(64)]
        public string ID { get; set; }

        [StringLength(100)]
        public string AREANAME { get; set; }

        [StringLength(12)]
        public string AREACODE { get; set; }

        [StringLength(11)]
        public string YLJGDM { get; set; }

        [StringLength(100)]
        public string YLJGMC { get; set; }

        [StringLength(100)]
        public string MCQR { get; set; }

        [StringLength(50)]
        public string LXDH { get; set; }

        [StringLength(100)]
        public string YJGDZ { get; set; }

        [StringLength(4)]
        public string GBNF { get; set; }

        [StringLength(11)]
        public string BSBCJGDM { get; set; }

        [StringLength(100)]
        public string BSBCJG { get; set; }

        [StringLength(5)]
        public string YLJGTYPE { get; set; }

        [StringLength(500)]
        public string BZ { get; set; }

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
