namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_OFFICE
    {
        [StringLength(64)]
        public string ID { get; set; }

        [StringLength(64)]
        public string PARENT_ID { get; set; }

        [StringLength(2000)]
        public string PARENT_IDS { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        public long? SORT { get; set; }

        [StringLength(64)]
        public string AREA_ID { get; set; }

        [StringLength(100)]
        public string CODE { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }

        [StringLength(1)]
        public string GRADE { get; set; }

        [StringLength(255)]
        public string ADDRESS { get; set; }

        [StringLength(100)]
        public string ZIP_CODE { get; set; }

        [StringLength(100)]
        public string MASTER { get; set; }

        [StringLength(200)]
        public string PHONE { get; set; }

        [StringLength(200)]
        public string FAX { get; set; }

        [StringLength(200)]
        public string EMAIL { get; set; }

        [StringLength(64)]
        public string CREATE_BY { get; set; }

        public DateTime? CREATE_DATE { get; set; }

        [StringLength(64)]
        public string UPDATE_BY { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(255)]
        public string REMARKS { get; set; }

        [StringLength(1)]
        public string DEL_FLAG { get; set; }

        [StringLength(1)]
        public string LV { get; set; }

        [StringLength(1)]
        public string CSZX { get; set; }

        [StringLength(1)]
        public string ZDZX { get; set; }

        [StringLength(1)]
        public string ZCJG { get; set; }

        [StringLength(100)]
        public string CODE22 { get; set; }

        [StringLength(100)]
        public string CODE9 { get; set; }

        [StringLength(11)]
        public string CODE11 { get; set; }

        [StringLength(2)]
        public string GFZZJGLB { get; set; }

        [StringLength(255)]
        public string CSZM_QFJG { get; set; }

        [StringLength(1)]
        public string XSEWZZY { get; set; }

        [StringLength(1)]
        public string WZYCFZY { get; set; }

        [StringLength(1)]
        public string HJJG { get; set; }

        [StringLength(2)]
        public string JGLB { get; set; }

        [StringLength(1)]
        public string FNBPC { get; set; }

        [StringLength(1)]
        public string JHSY { get; set; }

        [StringLength(1)]
        public string GNQJG { get; set; }

        [StringLength(1)]
        public string RSMDDD { get; set; }

        [StringLength(1)]
        public string XTMDDD { get; set; }

        [StringLength(1)]
        public string ZYFMMYYLB { get; set; }

        [StringLength(11)]
        public string WCECODE { get; set; }
    }
}
