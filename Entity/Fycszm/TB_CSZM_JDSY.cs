namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_JDSY
    {
        [StringLength(64)]
        public string ID { get; set; }

        [StringLength(4)]
        public string NF { get; set; }

        [StringLength(1)]
        public string JD { get; set; }

        [StringLength(12)]
        public string QXCODE { get; set; }

        [StringLength(100)]
        public string QXMC { get; set; }

        [StringLength(11)]
        public string QFJGCODE { get; set; }

        [StringLength(100)]
        public string QFJGMC { get; set; }

        public long? SJDSLQKCS { get; set; }

        public long? SJDSLS { get; set; }

        public long? DNCSSQS { get; set; }

        public long? JWNDCSSQS { get; set; }

        public long? JTJSQFS { get; set; }

        public long? HFS { get; set; }

        public long? BFS { get; set; }

        public long? JGWCSQFS { get; set; }

        public long? FZCWS { get; set; }

        public long? FZYSS { get; set; }

        public long? FZSHS { get; set; }

        public long? FZQTS { get; set; }

        public long? SJDKCS { get; set; }

        public long? SJDJGHCS { get; set; }

        public long? BJDSLS { get; set; }

        public DateTime? SBRQ { get; set; }

        [StringLength(32)]
        public string SBRID { get; set; }

        [StringLength(100)]
        public string SBRXM { get; set; }

        [StringLength(32)]
        public string QJSHRID { get; set; }

        [StringLength(100)]
        public string QJSHRMC { get; set; }

        public DateTime? QJSHRQ { get; set; }

        [StringLength(11)]
        public string QJSHJGCODE { get; set; }

        [StringLength(100)]
        public string QJSHJGMC { get; set; }

        [StringLength(400)]
        public string QJSHBTGYY { get; set; }

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

        [StringLength(2)]
        public string SHZT { get; set; }

        public DateTime? SCRQ { get; set; }

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
