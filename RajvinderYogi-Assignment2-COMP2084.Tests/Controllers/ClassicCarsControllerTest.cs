using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Moq;
using RajvinderYogi_Assignment1_COMP2084.Controllers;
using RajvinderYogi_Assignment2_COMP2084.Controllers;
using RajvinderYogi_Assignment1_COMP2084.Models;

namespace RajvinderYogi_Assignment2_COMP2084.Tests.Controllers
{
    [TestClass]
    public class ClassicCarsControllerTest
    {
        //global variables
        ClassicCarsController cont;
        Mock<InterfaceClassicCarsRepository> m;

        [TestInitialize]
        public void TestIntialize()
        {
            //Arrange
            m = new Mock<InterfaceClassicCarsRepository>();

            cont = new ClassicCarsController(m.Object);
        }
        [TestMethod]
        public void IndexLoadsValid()
        {
            //act
            ViewResult results = cont.Index() as ViewResult;
            //assert
            Assert.IsNotNull(results);
        }
       
    }
}
