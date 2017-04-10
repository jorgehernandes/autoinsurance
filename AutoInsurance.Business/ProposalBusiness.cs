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
                Calculate(obj);

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

        public bool Delete(Proposal obj)
        {
            ProposalRepository repository = new ProposalRepository();
            return repository.Delete(obj);
        }

        public void Calculate(Proposal obj)
        {
            obj.Value = (int)new Random().Next(500, 2000);
        }
    }
}