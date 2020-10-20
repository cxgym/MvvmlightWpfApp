namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CSZM_RCKDJ
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string RCKLSH { get; set; }

        [StringLength(100)]
        public string RK_CKMC { get; set; }

        [StringLength(11)]
        public string RK_ZZCKCODE { get; set; }

        public DateTime? RK_RQ { get; set; }

        [StringLength(10)]
        public string RK_BHQZ { get; set; }

        [StringLength(64)]
        public string RK_QSBH { get; set; }

        [StringLength(64)]
        public string RK_ZZBH { get; set; }

        [StringLength(10)]
        public string RK_ZJPC { get; set; }

        public long? RK_SL { get; set; }

        public long? YFP_SL { get; set; }

        [StringLength(10)]
        public string RK_LX { get; set; }

        [StringLength(100)]
        public string RK_CZRXM { get; set; }

        [StringLength(32)]
        public string RK_CZRCODE { get; set; }

        [StringLength(64)]
        public string SLDJ_LSH { get; set; }

        [StringLength(12)]
        public string SLSDM { get; set; }

        [StringLength(100)]
        public string SL_SMC { get; set; }

        [StringLength(12)]
        public string SL_QXDM { get; set; }

        [StringLength(100)]
        public string SL_QXMC { get; set; }

        [StringLength(11)]
        public string SL_JGCODE { get; set; }

        [StringLength(100)]
        public string SL_JGMC { get; set; }

        public DateTime? SL_RQ { get; set; }

        [StringLength(2)]
        public string CK_ZT { get; set; }

        [StringLength(12)]
        public string CK_ZZQXCODE { get; set; }

        [StringLength(100)]
        public string CK_ZZQXMC { get; set; }

        [StringLength(100)]
        public string CK_ZZJGMC { get; set; }

        [StringLength(11)]
        public string CK_ZZJGCODE { get; set; }

        public DateTime? CK_RQ { get; set; }

        [StringLength(10)]
        public string CK_BHQZ { get; set; }

        [StringLength(64)]
        public string CK_QSBH { get; set; }

        [StringLength(64)]
        public string CK_ZZBH { get; set; }

        public long? CK_SL { get; set; }

        [StringLength(2)]
        public string CK_LX { get; set; }

        [StringLength(100)]
        public string CK_CZRXM { get; set; }

        [StringLength(32)]
        public string CK_CZRCODE { get; set; }

        [StringLength(2)]
        public string FZ_YY { get; set; }

        [StringLength(100)]
        public string FZ_QTYY { get; set; }

        [StringLength(32)]
        public string FZ_JBRID { get; set; }

        [StringLength(100)]
        public string FZ_JBRXM { get; set; }

        [StringLength(100)]
        public string TB_MC { get; set; }

        [StringLength(11)]
        public string TB_ZZJGCODE { get; set; }

        [StringLength(12)]
        public string TB_QHDM { get; set; }

        [StringLength(64)]
        public string GL_RCKLSH { get; set; }

        [StringLength(200)]
        public string CRK_BZ { get; set; }

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
    }
}
