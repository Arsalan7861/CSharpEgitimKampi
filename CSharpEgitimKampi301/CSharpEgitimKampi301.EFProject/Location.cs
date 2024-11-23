namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        public int LocationId { get; set; }

        [StringLength(50)]
        public string LocationCity { get; set; }

        [StringLength(50)]
        public string LocationCountry { get; set; }

        public byte? LocationCapacity { get; set; }

        public decimal? LocationPrice { get; set; }

        [StringLength(50)]
        public string DayNight { get; set; }

        public int? GuideId { get; set; }

        public virtual Guide Guide { get; set; }
    }
}
