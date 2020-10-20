namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_PROXY_URL
    {
        [StringLength(64)]
        public string ID { get; set; }

        [Required]
        [StringLength(32)]
        public string S_CODE { get; set; }

        [StringLength(200)]
        public string S_NAME { get; set; }

        [Required]
        [StringLength(200)]
        public string S_URL { get; set; }

        [StringLength(32)]
        public string S_COUNTY { get; set; }

        [StringLength(1000)]
        public string S_PARAMETER { get; set; }

        [Required]
        [StringLength(32)]
        public string S_ORG_CODE { get; set; }

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
