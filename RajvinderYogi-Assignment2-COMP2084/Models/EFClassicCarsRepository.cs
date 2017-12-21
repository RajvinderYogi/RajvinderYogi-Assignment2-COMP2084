using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RajvinderYogi_Assignment1_COMP2084.Models
{
    public class EFClassicCarsRepository : InterfaceClassicCarsRepository
    {
        //repository for CRUD operations on live database

        // db connection
        VintageCarsModel db = new VintageCarsModel();

        public IQueryable<CarDetail> CarDetails
        {
            get
            {
                return db.CarDetails;
            }
        }

        public IQueryable<ClassicCar> ClassicCars
        {
            get
            {
                return db.ClassicCars;
            }
        }

        public void Delete(ClassicCar classiccar)
        {
            db.ClassicCars.Remove(classiccar);
            db.SaveChanges();
        }


        public ClassicCar Save(ClassicCar classiccar)
        {

            if (classiccar.CarId == 0)
            {
                db.ClassicCars.Add(classiccar);
            }
            else
            {
                db.Entry(classiccar).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            return classiccar;
        }
    }
}