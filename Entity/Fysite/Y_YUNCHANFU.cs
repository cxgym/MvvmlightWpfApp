namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Y_YUNCHANFU
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(2)]
        public string ZJLX { get; set; }

        [Required]
        [StringLength(32)]
        public string ZJHM { get; set; }

        [Required]
        [StringLength(64)]
        public string XM { get; set; }

        public DateTime CSRQ { get; set; }

        [Required]
        [StringLength(3)]
        public string GJ { get; set; }

        [StringLength(12)]
        public string HJDZSHEN { get; set; }

        [StringLength(12)]
        public string HJDZSHI { get; set; }

        [StringLength(12)]
        public string HJDZXIAN { get; set; }

        [StringLength(12)]
        public string HJDZJIEDAO { get; set; }

        [StringLength(12)]
        public string HJDZJUWEI { get; set; }

        [StringLength(200)]
        public string ADDRESS_HUJI { get; set; }

        [StringLength(12)]
        public string JZDZSHEN { get; set; }

        [StringLength(12)]
        public string JZDZSHI { get; set; }

        [StringLength(12)]
        public string JZDZXIAN { get; set; }

        [StringLength(12)]
        public string JZDZJIEDAO { get; set; }

        [StringLength(12)]
        public string JZDZJUWEI { get; set; }

        [StringLength(200)]
        public string ADDRESS_JUZHU { get; set; }

        [StringLength(32)]
        public string XYDZSHEN { get; set; }

        [StringLength(32)]
        public string XYDZSHI { get; set; }

        [StringLength(32)]
        public string XYDZXIAN { get; set; }

        [StringLength(32)]
        public string XYDZJIEDAO { get; set; }

        [StringLength(32)]
        public string XYDZJUWEI { get; set; }

        [StringLength(200)]
        public string ADDRESS_XIUYANG { get; set; }

        public DateTime? LHSJ { get; set; }

        [StringLength(11)]
        public string XYSQ { get; set; }

        [Required]
        [StringLength(2)]
        public string HJLX { get; set; }

        [StringLength(2)]
        public string ZY { get; set; }

        [StringLength(2)]
        public string JYCD { get; set; }

        [StringLength(32)]
        public string SJHM { get; set; }

        [StringLength(32)]
        public string LXDH { get; set; }

        [StringLength(2)]
        public string MARITAL { get; set; }

        [StringLength(2)]
        public string MZ { get; set; }

        [StringLength(32)]
        public string QTMZ { get; set; }

        [StringLength(2)]
        public string JJZK { get; set; }

        [StringLength(32)]
        public string JG { get; set; }

        [StringLength(32)]
        public string DW { get; set; }

        public decimal? JHNL { get; set; }

        public decimal? CCNL { get; set; }

        [StringLength(64)]
        public string ZFXM { get; set; }

        public decimal? ZFNL { get; set; }

        [StringLength(2)]
        public string ZFZY { get; set; }

        [StringLength(2)]
        public string ZFJK { get; set; }

        [StringLength(32)]
        public string ZFSJ { get; set; }

        [StringLength(2)]
        public string ZFXX { get; set; }

        [StringLength(2)]
        public string ZFRH { get; set; }

        [StringLength(2)]
        public string POWHCD { get; set; }

        public DateTime MCYJ { get; set; }

        public DateTime? ZJYCQ { get; set; }

        [StringLength(200)]
        public string YZJZYY { get; set; }

        public decimal? SG { get; set; }

        public decimal? YQTZ { get; set; }

        public decimal? YC { get; set; }

        public decimal? CC { get; set; }

        public decimal? ZRLCC { get; set; }

        public decimal? RGLCC { get; set; }

        [StringLength(30)]
        public string YCSYS { get; set; }

        public decimal? ZCCS { get; set; }

        public decimal? ST { get; set; }

        public decimal? SC { get; set; }

        public decimal? XSRSW { get; set; }

        public decimal? CSQX { get; set; }

        public decimal? XTCJ { get; set; }

        public decimal? YWRE { get; set; }

        public decimal? YCCS { get; set; }

        [StringLength(200)]
        public string YCSYSQT { get; set; }

        public decimal? ZYC { get; set; }

        public decimal? XYZNS { get; set; }

        [Required]
        [StringLength(2)]
        public string JAZT { get; set; }

        [StringLength(2)]
        public string GREENCODE { get; set; }

        [StringLength(255)]
        public string YELLOWCODE { get; set; }

        [StringLength(255)]
        public string CSCODE { get; set; }

        [StringLength(255)]
        public string REDCODE { get; set; }

        [StringLength(255)]
        public string ZSCODE { get; set; }

        [Required]
        [StringLength(2)]
        public string ZDYF { get; set; }

        [Required]
        [StringLength(2)]
        public string WZYF { get; set; }

        [Required]
        [StringLength(2)]
        public string BYJXRS { get; set; }

        [StringLength(12)]
        public string GLQX { get; set; }

        [StringLength(11)]
        public string GLSQ { get; set; }

        public DateTime? JASJ { get; set; }

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

        [StringLength(100)]
        public string ZDNR { get; set; }

        [StringLength(500)]
        public string ZDNRQT { get; set; }

        [StringLength(1024)]
        public string PGNR { get; set; }

        [StringLength(2)]
        public string CHFSBJ { get; set; }

        [StringLength(2)]
        public string ZFZJLX { get; set; }

        [StringLength(32)]
        public string ZFZJHM { get; set; }

        public DateTime? ZFCSRQ { get; set; }

        [StringLength(3)]
        public string ZFGJ { get; set; }

        [StringLength(2)]
        public string ZFMZ { get; set; }

        [StringLength(32)]
        public string ZFQTMZ { get; set; }

        [StringLength(12)]
        public string ZFHJDZSHEN { get; set; }

        [StringLength(12)]
        public string ZFHJDZSHI { get; set; }

        [StringLength(12)]
        public string ZFHJDZXIAN { get; set; }

        [StringLength(12)]
        public string ZFHJDZJIEDAO { get; set; }

        [StringLength(12)]
        public string ZFHJDZJUWEI { get; set; }

        [StringLength(200)]
        public string ZFADDRESS_HUJI { get; set; }

        [StringLength(2)]
        public string HBLX { get; set; }

        [StringLength(2)]
        public string CYZK { get; set; }

        [StringLength(2)]
        public string ZFCYZK { get; set; }

        public DateTime? ZFLHSJ { get; set; }

        [StringLength(100)]
        public string ZFDW { get; set; }
    }
}
