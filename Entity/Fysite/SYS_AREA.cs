namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_AREA
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

        [StringLength(100)]
        public string CODE { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }

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
