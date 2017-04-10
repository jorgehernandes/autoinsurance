using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsurance.Business;
using AutoInsurance.Model;

namespace AutoInsurance.Test
{
    [TestClass]
    public class ProposalTest
    {
        static Proposal proposal;

        [TestMethod]
        public void TestInsertProposal()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            CarBusiness carBusiness = new CarBusiness();
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Proposal newProposal = new Proposal();

            newProposal.Car = new Car
            {
                Id = carBusiness.FindById(1).Id
            };

            newProposal.Insured = new Insured
            {
                Id = insuredBusiness.FindById(1).Id
            };

            proposalBusiness.Calculate(newProposal);
            proposalBusiness.Save(newProposal);

            proposal = newProposal;

            Assert.IsTrue(proposal.Id > 0);
        }

        [TestMethod]
        public void TestFindAllProposals()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            Assert.IsTrue(proposalBusiness.FindAll().Count > 0);
        }

        [TestMethod]
        public void TestFindProposalById()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            Proposal testProposal = proposalBusiness.FindById(proposal.Id);

            Assert.AreEqual(testProposal.Id, proposal.Id);
        }

        [TestMethod]
        public void TestDeleteProposal()
        {
            ProposalBusiness proposalBusiness = new ProposalBusiness();
            Proposal deletedProposal = proposalBusiness.Delete(proposal.Id);

            Assert.AreEqual(deletedProposal.Id, proposal.Id);
        }
    }
}