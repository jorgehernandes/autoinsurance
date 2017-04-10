using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Model;
using AutoInsurance.Business;

namespace AutoInsurance.Test
{
    [TestClass]
    public class InsuredTest
    {
        static Insured insured = new Insured();

        [TestMethod]
        public void TestInsertInsured()
        {
            Insured newInsured = new Insured();
            newInsured.Age = 18;
            newInsured.FirstName = "Paulo";
            newInsured.LastName = "Silva";

            InsuredBusiness insuredBusiness = new InsuredBusiness();
            insuredBusiness.Save(newInsured);

            insured = newInsured;

            Assert.IsTrue(insured.Id > 0);
        }

        [TestMethod]
        public void TestFindAllInsureds()
        {
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Assert.IsTrue(insuredBusiness.FindAll().Count > 0);
        }

        [TestMethod]
        public void TestFindInsuredById()
        {
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Assert.IsTrue(insuredBusiness.FindById(insured.Id).Id == insured.Id);
        }

        [TestMethod]
        public void TestDeleteInsured()
        {
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Assert.AreEqual(insured.Id, insuredBusiness.Delete(insured.Id).Id);
        }

    }
}
