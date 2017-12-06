namespace RajvinderYogi_Assignment1_COMP2084.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassicCar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassicCar()
        {
            CarDetails = new HashSet<CarDetail>();
        }

        [Key]
        public int CarId { get; set; }

        [Required]
        [StringLength(20)]
        public string CarName { get; set; }

        public int MakeYear { get; set; }

        [Required]
        [StringLength(10)]
        public string Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarDetail> CarDetails { get; set; }
    }
}
