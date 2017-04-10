using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class ProposalRepository
    {
        static readonly Database database = new Database();

        public bool Save(Proposal obj)
        {
            try
            {
                obj.Car = database.Car.FirstOrDefault<Car>(m => m.Id == obj.Car.Id);
                obj.Insured = database.Insured.FirstOrDefault<Insured>(i => i.Id == obj.Insured.Id);
                database.Proposal.Add(obj);

                database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Proposal> FindAll()
        {
            try
            {
                return database.Proposal
                                .Include("Car")
                                .Include("Insured")
                                .ToList<Proposal>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Proposal FindById(int id)
        {
            Proposal proposal;

            try
            {
                proposal = (from p in database.Proposal
                            where p.Id == id
                            select p).FirstOrDefault<Proposal>();

                return proposal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Proposal Delete(int id)
        {
            try
            {
                Proposal proposal = FindById(id);
                Proposal deletedProposal = database.Proposal.Remove(proposal);
                database.SaveChanges();

                return deletedProposal;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}