using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Moq;
using RajvinderYogi_Assignment1_COMP2084.Controllers;
using RajvinderYogi_Assignment2_COMP2084.Controllers;
using RajvinderYogi_Assignment1_COMP2084.Models;
using System.Linq;

namespace RajvinderYogi_Assignment2_COMP2084.Tests.Controllers
{
    [TestClass]
    public class ClassicCarsControllerTest
    {
        //global variables
        ClassicCarsController cont;
        Mock<InterfaceClassicCarsRepository> moc;
        List<ClassicCar> classiccars;

        // test intialization: this would run for every test method
        [TestInitialize]
        public void TestIntialize()
        {
            //Arrange
            moc = new Mock<InterfaceClassicCarsRepository>();
            //mock data
            classiccars = new List<ClassicCar>
            {
                new ClassicCar {CarId = 1, CarName = "One Car", Country="One Country", MakeYear=1990 },
                new ClassicCar {CarId = 2, CarName = "Two Car", Country="Two Country", MakeYear=1991 },
                new ClassicCar {CarId = 3, CarName = "Three Car", Country="Three Country", MakeYear=1992 },
                new ClassicCar {CarId = 4, CarName = "Four Car", Country="Four Country", MakeYear=1993 },
                new ClassicCar {CarId = 5, CarName = "Five Car", Country="Five Country", MakeYear=1994 }
            };
            //add data to mock object
            moc.Setup(m => m.ClassicCars).Returns(classiccars.AsQueryable());

            cont = new ClassicCarsController(moc.Object);
        }
        //test methods for index of ClassicCars/Cars
        [TestMethod]
        public void IndexLoadsValid()
        {
            //Act
            ViewResult results = cont.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(results);
        }
        [TestMethod]
        public void IndexLoadsData()
        {
            //Act
            var act = (List<ClassicCar>)cont.Index().Model;

            //Assert
            CollectionAssert.AreEqual(classiccars, act);
        }

        //test method for details of ClassicCars/Cars
        //test method for NO id
        [TestMethod]
        public void DetailsNoId()
        {
            //Act
            ViewResult act = cont.Details(null);

            //Assert
            Assert.AreEqual("Error", act.ViewName);
        }
        //test method to check id is valid or not
        [TestMethod]
        public void DetailsValidId()
        {
            //Act
            var act = (ClassicCar)cont.Details(3).Model;

            //Assert
            Assert.AreEqual(classiccars.ToList()[2], act);
        }
        //test method to check invalid id
        [TestMethod]
        public void DetailsInvalidId()
        {
            //Act
            ViewResult act = cont.Details(10);

            //Assert
            Assert.AreEqual("Error", act.ViewName);
        }

        //test method for Delete Confirmation of ClassicCars/Cars
        //test method for NO id
        [TestMethod]
        public void DeleteConfirmNoId()
        {
            //Act
            ViewResult act = cont.DeleteConfirmed(null);

            //Assert
            Assert.AreEqual("Error", act.ViewName);
        }
        //test method to check id is valid or not
        [TestMethod]
        public void DeleteConfirmValidId()
        {
            //Act
            ViewResult act = cont.DeleteConfirmed(3);

            //Assert
            Assert.AreEqual("Index", act.ViewName);
        }
        //test method to check invalid id
        [TestMethod]
        public void DeleteConfirmInvalidId()
        {
            //Act
            ViewResult act = cont.DeleteConfirmed(10);

            //Assert
            Assert.AreEqual("Error", act.ViewName);
        }
    }
}
