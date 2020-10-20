namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_LOG
    {
        [StringLength(64)]
        public string ID { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }

        [StringLength(500)]
        public string TITLE { get; set; }

        [StringLength(64)]
        public string CREATE_BY { get; set; }

        public DateTime? CREATE_DATE { get; set; }

        [StringLength(255)]
        public string REMOTE_ADDR { get; set; }

        [StringLength(255)]
        public string USER_AGENT { get; set; }

        [StringLength(255)]
        public string REQUEST_URI { get; set; }

        [StringLength(5)]
        public string METHOD { get; set; }

        [StringLength(2147483647)]
        public string PARAMS { get; set; }

        [StringLength(2147483647)]
        public string EXCEPTION { get; set; }
    }
}
