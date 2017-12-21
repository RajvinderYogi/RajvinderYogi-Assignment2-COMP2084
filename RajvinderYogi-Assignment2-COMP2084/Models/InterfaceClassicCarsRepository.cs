using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RajvinderYogi_Assignment1_COMP2084.Models;

namespace RajvinderYogi_Assignment1_COMP2084.Models
{
    //moq repository for unit testing
    public interface InterfaceClassicCarsRepository
    {
        IQueryable<ClassicCar> ClassicCars { get; }
        IQueryable<CarDetail> CarDetails { get; }
       
        ClassicCar Save(ClassicCar classiccar);
        void Delete(ClassicCar classiccar);
    }
}
