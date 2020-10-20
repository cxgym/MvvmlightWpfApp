namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Y_FENMIAN
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string YID { get; set; }

        public DateTime FMRQ { get; set; }

        [Required]
        [StringLength(10)]
        public string FMYZCODE { get; set; }

        [Required]
        [StringLength(10)]
        public string FMFS { get; set; }

        [StringLength(32)]
        public string FMFSTC { get; set; }

        [Required]
        [StringLength(10)]
        public string ZYFM { get; set; }

        [StringLength(255)]
        public string ZYFMSM { get; set; }

        public decimal XSS { get; set; }

        public decimal CJCS { get; set; }

        [Required]
        [StringLength(10)]
        public string TS { get; set; }

        public decimal? TSNUM { get; set; }

        [Required]
        [StringLength(10)]
        public string TP { get; set; }

        [StringLength(10)]
        public string SSMC { get; set; }

        [StringLength(32)]
        public string SSMCTC { get; set; }

        [Required]
        [StringLength(10)]
        public string FMDDCODE { get; set; }

        [StringLength(255)]
        public string FMDD { get; set; }

        [StringLength(32)]
        public string PGCZZCODE { get; set; }

        [StringLength(255)]
        public string PGCZZ { get; set; }

        [StringLength(20)]
        public string CFYS { get; set; }

        [StringLength(256)]
        public string QTCFYS { get; set; }

        [StringLength(20)]
        public string TEYS { get; set; }

        [StringLength(256)]
        public string QTTEYS { get; set; }

        [Column(TypeName = "real")]
        public double? SSCXL { get; set; }

        [StringLength(255)]
        public string SZYCQK { get; set; }

        [Required]
        [StringLength(32)]
        public string RSHBZ { get; set; }

        [StringLength(128)]
        public string RSHBZQT { get; set; }

        [Required]
        [StringLength(32)]
        public string CRGR { get; set; }

        [Required]
        [StringLength(10)]
        public string HIVZX { get; set; }

        [Required]
        [StringLength(10)]
        public string HIVKTJC { get; set; }

        [StringLength(10)]
        public string DZD { get; set; }

        [Required]
        [StringLength(10)]
        public string KYXQXSY { get; set; }

        [StringLength(10)]
        public string MDDZD { get; set; }

        [Required]
        [StringLength(10)]
        public string HBSAGJC { get; set; }

        [StringLength(10)]
        public string HBSQG { get; set; }

        [Required]
        [StringLength(10)]
        public string ZDZXQQ { get; set; }

        [Required]
        [StringLength(10)]
        public string ZGPL { get; set; }

        [Required]
        [StringLength(10)]
        public string CHCX { get; set; }

        [StringLength(20)]
        public string CHCXYY { get; set; }

        [StringLength(256)]
        public string CHCXYYQT { get; set; }

        public DateTime ZYSJ { get; set; }

        [Required]
        [StringLength(10)]
        public string YCFSW { get; set; }

        [Required]
        [StringLength(10)]
        public string HSYCMY { get; set; }

        public DateTime? CYRQ { get; set; }

        [StringLength(64)]
        public string JKDAH { get; set; }

        public DateTime? JDSJ { get; set; }

        [StringLength(64)]
        public string BAH { get; set; }

        [StringLength(10)]
        public string NCZSCODE { get; set; }

        [StringLength(32)]
        public string NCZS { get; set; }

        [StringLength(10)]
        public string FMZTCODE { get; set; }

        [StringLength(32)]
        public string FMZT { get; set; }

        [StringLength(10)]
        public string PBCODE { get; set; }

        [StringLength(32)]
        public string PB { get; set; }

        [StringLength(10)]
        public string HYLSCDCODE { get; set; }

        [StringLength(255)]
        public string HYLSCD { get; set; }

        [StringLength(10)]
        public string HYQK { get; set; }

        [Column(TypeName = "real")]
        public double? SXL { get; set; }

        public decimal? CCSJ1S { get; set; }

        public decimal? CCSJ1F { get; set; }

        public decimal? CCSJ2S { get; set; }

        public decimal? CCSJ2F { get; set; }

        public decimal? CCSJ3S { get; set; }

        public decimal? CCSJ3F { get; set; }

        public long? CCSJZS { get; set; }

        public long? CCSJZF { get; set; }

        [StringLength(255)]
        public string FMYCQK { get; set; }

        [StringLength(32)]
        public string JCZ { get; set; }

        [Required]
        [StringLength(10)]
        public string ZGCQ { get; set; }

        [StringLength(500)]
        public string SHYS { get; set; }

        [StringLength(500)]
        public string PGQTYS { get; set; }

        [StringLength(64)]
        public string ZYH { get; set; }

        public decimal CH2XSSSY { get; set; }

        public decimal CH2XSSZY { get; set; }

        [Column(TypeName = "real")]
        public double CHCXL { get; set; }

        public decimal? PGCSJH { get; set; }

        public decimal? PGCSJF { get; set; }

        [Required]
        [StringLength(11)]
        public string JGCODE { get; set; }

        [Required]
        [StringLength(12)]
        public string QXCODE { get; set; }

        [Required]
        [StringLength(32)]
        public string BGYSID { get; set; }

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

        [StringLength(10)]
        public string FMFSDFL { get; set; }
    }
}
