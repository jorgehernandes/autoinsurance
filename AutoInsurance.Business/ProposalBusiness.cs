using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;

namespace AutoInsurance.Business
{
    public class ProposalBusiness
    {
        public bool Save(Proposal obj)
        {
            try
            {
                ProposalRepository repository = new ProposalRepository();
                return repository.Save(obj);
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
                ProposalRepository repository = new ProposalRepository();
                return repository.FindAll();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Proposal FindById(int Id)
        {
            ProposalRepository repository = new ProposalRepository();
            return repository.FindById(Id);
        }

        public Proposal Delete(int id)
        {
            ProposalRepository repository = new ProposalRepository();
            return repository.Delete(id);
        }

        public void Calculate(Proposal obj)
        {
            obj.Value = new Random().Next(500, 2000);
        }
    }
}