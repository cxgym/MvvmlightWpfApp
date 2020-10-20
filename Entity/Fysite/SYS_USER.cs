namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_USER
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string COMPANY_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string LOGIN_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string PASSWORD { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string CREATE_BY { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(64)]
        public string UPDATE_BY { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UPDATE_DATE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string DEL_FLAG { get; set; }

        [StringLength(64)]
        public string OFFICE_ID { get; set; }

        [StringLength(100)]
        public string NO { get; set; }

        [StringLength(200)]
        public string EMAIL { get; set; }

        [StringLength(200)]
        public string PHONE { get; set; }

        [StringLength(200)]
        public string MOBILE { get; set; }

        [StringLength(1)]
        public string USER_TYPE { get; set; }

        [StringLength(1000)]
        public string PHOTO { get; set; }

        [StringLength(100)]
        public string LOGIN_IP { get; set; }

        public DateTime? LOGIN_DATE { get; set; }

        [StringLength(64)]
        public string LOGIN_FLAG { get; set; }

        [StringLength(255)]
        public string REMARKS { get; set; }

        [StringLength(1000)]
        public string YONGHU_SIGN_ML { get; set; }

        [StringLength(255)]
        public string YONGHU_SIGN_WJM { get; set; }
    }
}
