namespace RajvinderYogi_Assignment1_COMP2084.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarDetail
    {
        [Key]
        public int DetailsId { get; set; }

        public int CarId { get; set; }

        [Required]
        [StringLength(20)]
        public string CarBrand { get; set; }

        [Required]
        [StringLength(20)]
        public string CarModel { get; set; }

        public int CarYear { get; set; }

        public virtual ClassicCar ClassicCar { get; set; }
    }
}
