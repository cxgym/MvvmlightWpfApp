namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_LXQKJLB
    {
        [Key]
        [StringLength(64)]
        public string LXQK_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string QXDM { get; set; }

        [Required]
        [StringLength(11)]
        public string YLJGDM { get; set; }

        [StringLength(100)]
        public string YLJGMC { get; set; }

        public DateTime LXKSSJ { get; set; }

        public long? LXSC { get; set; }

        public DateTime? LXJSSJ { get; set; }

        public long? XSEDSC { get; set; }

        public long? XSESJSC { get; set; }

        public long? CSZDSC { get; set; }

        public long? CSZSJSC { get; set; }

        public long? BFDJDSC { get; set; }

        public long? BFDJSJSC { get; set; }

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
