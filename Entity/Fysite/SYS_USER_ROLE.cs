namespace MvvmlightWpfApp.Entity.Fysite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_USER_ROLE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(64)]
        public string USER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string ROLE_ID { get; set; }
    }
}
