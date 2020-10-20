namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Y_CSZMXX
    {
        [Key]
        [StringLength(18)]
        public string XSE_BM { get; set; }

        [Required]
        [StringLength(10)]
        public string CSYXZMBH { get; set; }

        [StringLength(50)]
        public string XSE_XM { get; set; }

        [StringLength(1)]
        public string XSE_XB { get; set; }

        public DateTime? XSE_CSSJ { get; set; }

        public long? XSE_YZ { get; set; }

        public long? XSE_TZ { get; set; }

        [Column(TypeName = "real")]
        public double? XSE_SC { get; set; }

        [StringLength(70)]
        public string CSDD_S { get; set; }

        [StringLength(70)]
        public string CSDD_SD { get; set; }

        [StringLength(70)]
        public string CSDD_XQ { get; set; }

        [StringLength(6)]
        public string CSD_QHDM { get; set; }

        [StringLength(6)]
        public string CSD_CSDLX { get; set; }

        [StringLength(11)]
        public string YLJGDM { get; set; }

        [StringLength(70)]
        public string YLJGMC { get; set; }

        [StringLength(200)]
        public string CSDDQT { get; set; }

        [StringLength(50)]
        public string JSRY { get; set; }

        [StringLength(50)]
        public string MQ_XM { get; set; }

        [StringLength(64)]
        public string MQ_BAH { get; set; }

        public DateTime? MQ_CSRQ { get; set; }

        [StringLength(2)]
        public string MQ_NL { get; set; }

        [StringLength(3)]
        public string MQ_GJ { get; set; }

        [StringLength(4)]
        public string MQ_MZ { get; set; }

        [StringLength(70)]
        public string MQ_HJ { get; set; }

        [StringLength(2)]
        public string MQ_HJSJDM { get; set; }

        [StringLength(200)]
        public string MQ_ZZSHEN { get; set; }

        [StringLength(200)]
        public string MQ_ZZSHI { get; set; }

        [StringLength(200)]
        public string MQ_ZZQU { get; set; }

        [StringLength(200)]
        public string MQ_ZZ { get; set; }

        [StringLength(2)]
        public string MQ_SFZJLX { get; set; }

        [StringLength(18)]
        public string MQ_SFZJHM { get; set; }

        [StringLength(50)]
        public string FQ_XM { get; set; }

        public DateTime? FQ_CSRQ { get; set; }

        [StringLength(2)]
        public string FQ_NL { get; set; }

        [StringLength(3)]
        public string FQ_GJ { get; set; }

        [StringLength(4)]
        public string FQ_MZ { get; set; }

        [StringLength(200)]
        public string FQ_ZZSHEN { get; set; }

        [StringLength(200)]
        public string FQ_ZZSHI { get; set; }

        [StringLength(200)]
        public string FQ_ZZQU { get; set; }

        [StringLength(200)]
        public string FQ_ZZ { get; set; }

        [StringLength(2)]
        public string FQ_SFZJLX { get; set; }

        [StringLength(18)]
        public string FQ_SFZHM { get; set; }

        [StringLength(50)]
        public string LZR_XM { get; set; }

        [StringLength(1)]
        public string LZR_YXSEGX { get; set; }

        [StringLength(2)]
        public string LZR_SFZJLB { get; set; }

        [StringLength(18)]
        public string LZR_SFZJHM { get; set; }

        [StringLength(32)]
        public string LZR_ZMCL { get; set; }

        [StringLength(255)]
        public string LZR_ZMCLQT { get; set; }

        [StringLength(70)]
        public string QFJG_MC { get; set; }

        [StringLength(6)]
        public string QFJG_QHDM { get; set; }

        [StringLength(11)]
        public string QFJG_ZZJGDM { get; set; }

        [StringLength(4)]
        public string QFJG_LBDM { get; set; }

        [StringLength(50)]
        public string QF_RY { get; set; }

        [StringLength(1)]
        public string QF_LX { get; set; }

        [StringLength(200)]
        public string QF_LXQT { get; set; }

        [StringLength(10)]
        public string YZ_BH { get; set; }

        [StringLength(1)]
        public string YZ_JHQK { get; set; }

        [StringLength(1)]
        public string HFYY { get; set; }

        [StringLength(1)]
        public string BFYY { get; set; }

        public DateTime? QF_RQ { get; set; }

        [StringLength(200)]
        public string QF_BZ { get; set; }

        [StringLength(1)]
        public string CSTC { get; set; }

        [StringLength(1)]
        public string CSTX { get; set; }

        [StringLength(20)]
        public string TYBS { get; set; }

        public DateTime? TYSJ { get; set; }

        [StringLength(255)]
        public string TYYY { get; set; }

        public DateTime? LYSJ { get; set; }
    }
}
