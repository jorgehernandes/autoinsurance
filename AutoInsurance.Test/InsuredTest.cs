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
        [TestMethod]
        public void TestInsertInsured()
        {
            Insured insured = new Insured();
            insured.Age = 18;
            insured.FirstName = "Paulo";
            insured.LastName = "Silva";

            InsuredBusiness insuredBusiness = new InsuredBusiness();
            insuredBusiness.Save(insured);

            Assert.IsTrue(insured.Id > 0);
        }

        [TestMethod]
        public void TestFindInsured()
        {
            Insured insured = new Insured();
            insured.Age = 18;
            insured.FirstName = "Paulo";
            insured.LastName = "Silva";

            InsuredBusiness insuredBusiness = new InsuredBusiness();
            insuredBusiness.Save(insured);

            Assert.IsTrue(insuredBusiness.FindById(insured.Id).Id == insured.Id);
        }

        [TestMethod]
        public void TestFindAllInsureds()
        {
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Assert.IsTrue(insuredBusiness.FindAll().Count > 0);
        }
    }
}
