namespace GGW.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class news
    {
        public int id { get; set; }

        [StringLength(30)]
        public string title { get; set; }

        public TimeSpan? uptime { get; set; }

        [StringLength(200)]
        public string nr { get; set; }
    }
}
