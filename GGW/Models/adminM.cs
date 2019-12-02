namespace GGW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("adminM")]
    public partial class adminM
    {
        [Key]
        public int adminID { get; set; }

        [Required]
        [StringLength(20)]
        public string adminName { get; set; }

        [Required]
        [StringLength(18)]
        public string adminPwd { get; set; }
    }
}
