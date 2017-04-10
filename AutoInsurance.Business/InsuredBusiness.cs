using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;

namespace AutoInsurance.Business
{
    public class InsuredBusiness
    {
        public bool Save(Insured obj)
        {
            try
            {
                InsuredRepository repository = new InsuredRepository();
                return repository.Save(obj);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<Insured> FindAll()
        {
            try
            {
                InsuredRepository repository = new InsuredRepository();
                return repository.FindAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Insured FindById(int Id)
        {
            try
            {
                InsuredRepository repository = new InsuredRepository();
                return repository.FindById(Id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Insured Delete(int id)
        {
            InsuredRepository repository = new InsuredRepository();
            return repository.Delete(id);
        }
    }
}