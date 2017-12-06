namespace RajvinderYogi_Assignment1_COMP2084.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VintageCarsModel : DbContext
    {
        public VintageCarsModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<CarDetail> CarDetails { get; set; }
        public virtual DbSet<ClassicCar> ClassicCars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarDetail>()
                .Property(e => e.CarBrand)
                .IsFixedLength();

            modelBuilder.Entity<CarDetail>()
                .Property(e => e.CarModel)
                .IsFixedLength();

            modelBuilder.Entity<ClassicCar>()
                .Property(e => e.CarName)
                .IsFixedLength();

            modelBuilder.Entity<ClassicCar>()
                .Property(e => e.Country)
                .IsFixedLength();

            modelBuilder.Entity<ClassicCar>()
                .HasMany(e => e.CarDetails)
                .WithRequired(e => e.ClassicCar)
                .WillCascadeOnDelete(false);
        }
    }
}
