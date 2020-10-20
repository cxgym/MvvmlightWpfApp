namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_ROLE
    {
        [StringLength(64)]
        public string ID { get; set; }

        [StringLength(64)]
        public string OFFICE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string ENNAME { get; set; }

        [StringLength(255)]
        public string ROLE_TYPE { get; set; }

        [StringLength(1)]
        public string DATA_SCOPE { get; set; }

        [StringLength(64)]
        public string IS_SYS { get; set; }

        [StringLength(64)]
        public string USEABLE { get; set; }

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

        [StringLength(64)]
        public string M_TYPE { get; set; }

        [StringLength(64)]
        public string M_LEVEL { get; set; }

        [StringLength(64)]
        public string M_TYPE_S { get; set; }

        [StringLength(64)]
        public string OFF_LEVEL { get; set; }
    }
}
