namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_CSZMXX
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string CSZMBH { get; set; }

        [Required]
        [StringLength(64)]
        public string XSE_NO { get; set; }

        [StringLength(100)]
        public string XSEXM { get; set; }

        [StringLength(10)]
        public string XB { get; set; }

        public DateTime? CSSJ { get; set; }

        public long? XSE_YZ { get; set; }

        [Column(TypeName = "real")]
        public double? TZ { get; set; }

        [Column(TypeName = "real")]
        public double? TC { get; set; }

        [StringLength(12)]
        public string CSDDSHEN { get; set; }

        [StringLength(12)]
        public string CSDDSHI { get; set; }

        [StringLength(12)]
        public string CSDDQU { get; set; }

        [StringLength(10)]
        public string FMDDCODE { get; set; }

        [StringLength(255)]
        public string FMDDQT { get; set; }

        [StringLength(11)]
        public string YLJGDM { get; set; }

        [StringLength(100)]
        public string YLJGMC { get; set; }

        [StringLength(10)]
        public string TS { get; set; }

        public long? BIRTHORDER { get; set; }

        [StringLength(100)]
        public string MQ_XM { get; set; }

        [StringLength(2)]
        public string MQ_ZJLX { get; set; }

        [StringLength(32)]
        public string MQ_ZJHM { get; set; }

        public DateTime? MQ_CSRQ { get; set; }

        [StringLength(64)]
        public string BAH { get; set; }

        [StringLength(3)]
        public string MQ_GJ { get; set; }

        [StringLength(100)]
        public string MQ_GJQT { get; set; }

        [StringLength(2)]
        public string MQ_MZ { get; set; }

        [StringLength(100)]
        public string MQ_MZQT { get; set; }

        [StringLength(12)]
        public string MQ_HJSJDM { get; set; }

        [StringLength(100)]
        public string MQ_HJSJMC { get; set; }

        [StringLength(12)]
        public string MQ_DYDZSHEN { get; set; }

        [StringLength(12)]
        public string MQ_DYDZSHI { get; set; }

        [StringLength(12)]
        public string MQ_DYDZXIAN { get; set; }

        [StringLength(200)]
        public string MQ_DYDZ { get; set; }

        [StringLength(100)]
        public string FQ_XM { get; set; }

        [StringLength(2)]
        public string FQ_ZJLX { get; set; }

        [StringLength(32)]
        public string FQ_ZJHM { get; set; }

        public DateTime? FQ_CSRQ { get; set; }

        [StringLength(3)]
        public string FQ_GJ { get; set; }

        [StringLength(100)]
        public string FQ_GJQT { get; set; }

        [StringLength(2)]
        public string FQ_MZ { get; set; }

        [StringLength(100)]
        public string FQ_MZQT { get; set; }

        [StringLength(12)]
        public string FQ_DYDZSHEN { get; set; }

        [StringLength(12)]
        public string FQ_DYDZSHI { get; set; }

        [StringLength(12)]
        public string FQ_DYDZXIAN { get; set; }

        [StringLength(200)]
        public string FQ_DYDZ { get; set; }

        [StringLength(100)]
        public string JCZXM { get; set; }

        [StringLength(100)]
        public string LZR_XM { get; set; }

        [StringLength(2)]
        public string LZR_YXSEGX { get; set; }

        [StringLength(100)]
        public string LZR_YXSEGXQT { get; set; }

        [StringLength(2)]
        public string LZR_SFZJLB { get; set; }

        [StringLength(32)]
        public string LZR_SFZJHM { get; set; }

        [StringLength(32)]
        public string LZR_ZMCL { get; set; }

        [StringLength(2)]
        public string LZR_QZJD { get; set; }

        [StringLength(100)]
        public string LZR_ZMCLQT { get; set; }

        [StringLength(2)]
        public string QFLX { get; set; }

        [StringLength(200)]
        public string QFLXQT { get; set; }

        [StringLength(10)]
        public string YZ_BH { get; set; }

        [StringLength(2)]
        public string YZ_JHQK { get; set; }

        [StringLength(2)]
        public string HFYY { get; set; }

        [StringLength(2)]
        public string BFYY { get; set; }

        [StringLength(500)]
        public string QFBZ { get; set; }

        [StringLength(11)]
        public string QFJGCODE { get; set; }

        [StringLength(100)]
        public string QFJGNM { get; set; }

        [StringLength(100)]
        public string CSZQF_MC { get; set; }

        [StringLength(32)]
        public string QFRYID { get; set; }

        [StringLength(100)]
        public string QFRYMC { get; set; }

        public DateTime? QFRQ { get; set; }

        [StringLength(2)]
        public string SFFZ { get; set; }

        [StringLength(2)]
        public string FZYY { get; set; }

        [StringLength(2)]
        public string QFZT { get; set; }

        public DateTime? SJQFRQ { get; set; }

        [StringLength(32)]
        public string SJQFRID { get; set; }

        [StringLength(100)]
        public string SJQFRXM { get; set; }

        public DateTime? TYSJ { get; set; }

        [StringLength(200)]
        public string TYYY { get; set; }

        public DateTime? DYSJ { get; set; }

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
        public string LXBS { get; set; }

        public DateTime? SCSJ { get; set; }

        [StringLength(32)]
        public string HYZK { get; set; }

        [StringLength(200)]
        public string MQ_ZJLXQT { get; set; }

        [StringLength(200)]
        public string FQ_ZJLXQT { get; set; }
    }
}
