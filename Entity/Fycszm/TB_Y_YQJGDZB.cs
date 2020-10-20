namespace MvvmlightWpfApp.Entity.Fycszm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Y_YQJGDZB
    {
        [Key]
        [StringLength(64)]
        public string YQJG_DM { get; set; }

        [StringLength(64)]
        public string YQJG_MC { get; set; }

        [Required]
        [StringLength(64)]
        public string EQJG_DM { get; set; }

        [StringLength(64)]
        public string EQJG_MC { get; set; }
    }
}
