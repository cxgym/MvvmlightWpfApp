namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Y_FANGSHI_YUNFU
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(64)]
        public string YID { get; set; }

        [Required]
        [StringLength(64)]
        public string SFLSH { get; set; }

        [Required]
        [StringLength(11)]
        public string JGCODE { get; set; }

        public DateTime INTERVIEWDATE { get; set; }

        public decimal? CHANHOUDAYS { get; set; }

        public decimal? TIWEN { get; set; }

        public decimal? XUEYA1 { get; set; }

        public decimal? XUEYA2 { get; set; }

        [StringLength(10)]
        public string RUZHI { get; set; }

        [StringLength(10)]
        public string RUFANGZHANGTONG { get; set; }

        [StringLength(10)]
        public string HONGZHONG { get; set; }

        [StringLength(10)]
        public string RUTOU { get; set; }

        [StringLength(10)]
        public string RUFANGZHANGTONG_R { get; set; }

        [StringLength(10)]
        public string HONGZHONG_R { get; set; }

        [StringLength(10)]
        public string RUTOU_R { get; set; }

        [StringLength(10)]
        public string GONGDI { get; set; }

        [StringLength(64)]
        public string CHIGU { get; set; }

        [StringLength(10)]
        public string YATONG { get; set; }

        [StringLength(10)]
        public string ZHIDI { get; set; }

        [StringLength(10)]
        public string ELOU { get; set; }

        [StringLength(10)]
        public string ELOUSE { get; set; }

        [StringLength(10)]
        public string ELOULIANG { get; set; }

        [StringLength(10)]
        public string ELOUWEI { get; set; }

        [StringLength(10)]
        public string RUFANG { get; set; }

        [Required]
        [StringLength(64)]
        public string STATUS { get; set; }

        [StringLength(10)]
        public string ZIGONG { get; set; }

        [StringLength(255)]
        public string ZIGONGREMARK { get; set; }

        [StringLength(10)]
        public string SHANGKOU { get; set; }

        [StringLength(255)]
        public string SHANGKOUREMARK { get; set; }

        [StringLength(10)]
        public string FENLEI { get; set; }

        [StringLength(255)]
        public string FENLEIREMARK { get; set; }

        [StringLength(10)]
        public string HUIYIN { get; set; }

        [StringLength(255)]
        public string HUIYINREMARK { get; set; }

        [StringLength(2)]
        public string CFJGZC { get; set; }

        [StringLength(255)]
        public string CFJGQTREMARK { get; set; }

        [StringLength(2)]
        public string ZDWS { get; set; }

        [StringLength(255)]
        public string ZDWSREMARK { get; set; }

        [StringLength(2)]
        public string ZDXL { get; set; }

        [StringLength(255)]
        public string ZDXLREMARK { get; set; }

        [StringLength(2)]
        public string ZDYY { get; set; }

        [StringLength(255)]
        public string ZDYYREMARK { get; set; }

        [StringLength(2)]
        public string ZDMR { get; set; }

        [StringLength(255)]
        public string ZDMRREMARK { get; set; }

        [StringLength(2)]
        public string ZDHL { get; set; }

        [StringLength(255)]
        public string ZDHLREMARK { get; set; }

        [StringLength(2)]
        public string ZDQT { get; set; }

        [StringLength(255)]
        public string ZDQTREMARK { get; set; }

        [StringLength(10)]
        public string ZHUANZHEN { get; set; }

        [StringLength(255)]
        public string REASON { get; set; }

        [StringLength(64)]
        public string JGKS { get; set; }

        [StringLength(64)]
        public string KS { get; set; }

        [StringLength(255)]
        public string JIANKANGINFO { get; set; }

        [StringLength(255)]
        public string XINLIINFO { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public DateTime? NEXTINTERVIEWDATE { get; set; }

        [StringLength(4)]
        public string LASTSUIFANG { get; set; }

        [Required]
        [StringLength(32)]
        public string SUIFANGRENCODE { get; set; }

        [Required]
        [StringLength(12)]
        public string QXCODE { get; set; }

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

        [StringLength(255)]
        public string QTZZYY { get; set; }

        [StringLength(10)]
        public string RUZHI_R { get; set; }

        [StringLength(10)]
        public string RUFANG_R { get; set; }

        [StringLength(2)]
        public string ZDYD { get; set; }

        [StringLength(255)]
        public string ZDYDREMARK { get; set; }

        [StringLength(2)]
        public string ZDZWJC { get; set; }

        [StringLength(255)]
        public string ZDZWJCREMARK { get; set; }

        [StringLength(2)]
        public string ZDXBJ { get; set; }

        [StringLength(255)]
        public string ZDXBJREMARK { get; set; }

        [StringLength(2)]
        public string ZDBY { get; set; }

        [StringLength(255)]
        public string ZDBYREMARK { get; set; }
    }
}
