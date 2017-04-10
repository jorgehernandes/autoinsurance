using AutoInsurance.Business;
using AutoInsurance.Model;
using AutoInsurance.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoInsurance.Web.Controllers
{
    public class ProposalController : Controller
    {
        public ActionResult Index(ProposalViewModel obj)
        {
            Proposal proposal = new Proposal();

            ProposalBusiness proposalBusiness = new ProposalBusiness();

            proposalBusiness.Calculate(proposal);

            obj.Value = proposal.Value;
            return View(obj);
        }

        public ActionResult ListProposal(string NameSearch)
        {
            ProposalBusiness proposal = new ProposalBusiness();

            if (NameSearch == null)
            {
                return View(proposal.FindAll());
            }
            else
            {
                return View(proposal.FindAll().FindAll(p => p.Insured.FirstName.Contains(NameSearch)));
            }
            
        }

        public ActionResult Save(ProposalViewModel obj)
        {
            InsuredBusiness insuredBusiness = new InsuredBusiness();

            Insured insured = new Insured
            {
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                Age = obj.Age,
                Cpf = obj.Cpf,
                Rg = obj.Rg,
                Gender = obj.Gender
            };

            if (insuredBusiness.Save(insured))
            {

                Proposal proposal = new Proposal();

                proposal.Car = new Car
                {
                    Id = obj.CarId
                };

                proposal.Insured = new Insured
                {
                    Id = insured.Id
                };

                proposal.Value = obj.Value;

                ProposalBusiness proposalBusiness = new ProposalBusiness();
                proposalBusiness.Save(proposal);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
