using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Business;
using AutoInsurance.Model;

namespace AutoInsurance.Test
{
    [TestClass]
    public class ProposalTest
    {
        [TestMethod]
        public void TestInsertProposal()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            CarBusiness carBusiness = new CarBusiness();
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Proposal proposal = new Proposal();
            proposal.Car = carBusiness.FindById(1);
            proposal.Insured = insuredBusiness.FindById(1);

            proposalBusiness.Save(proposal);

            Assert.IsTrue(proposal.Id > 0);
        }

        [TestMethod]
        public void TestFindAllProposals()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            Assert.IsTrue(proposalBusiness.FindAll().Count > 0);
        }
    }
}