using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Model;
using AutoInsurance.Business;

namespace AutoInsurance.Test
{
    /// <summary>
    /// Summary description for CarTest
    /// </summary>
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestInsertCar()
        {
            Car carModel = new Car()
            {
                Manufacturer = "GM",
                Model = "Corsa",
                Year = 2000,
                Photo = "about:blank"
            };
            CarBusiness carBusiness = new CarBusiness();
            carBusiness.Save(carModel);

            Assert.IsTrue(carModel.Id > 0);
        }

        [TestMethod]
        public void TestFindCar()
        {
            CarBusiness carBusiness = new CarBusiness();
            List<Car> cars = carBusiness.FindAll();

            Assert.IsTrue(cars.Count > 0);
        }
        [TestMethod]
        public void TestFindCarById()
        {
            CarBusiness carBusiness = new CarBusiness();
            Car car = new Car() 
            { 
                Manufacturer = "Fiat",
                Model = "500",
                Year = 2001,
                Photo = "about:blank"            
            };

            carBusiness.Save(car);
            Assert.AreNotEqual(null, carBusiness.FindById(car.Id));

           
           
            
        }
    }
}
