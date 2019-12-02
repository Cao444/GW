namespace GGW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("II")]
    public partial class II
    {
        public int id { get; set; }

        [StringLength(100)]
        public string imgLL { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(100)]
        public string nr { get; set; }
    }
}
