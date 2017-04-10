using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class InsuredRepository
    {
        static readonly Database database = new Database();

        public bool Save(Insured obj)
        {
            try
            {
                database.Insured.Add(obj);
                database.SaveChanges();
                return true;
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
                return (from i in database.Insured 
                        select i).ToList<Insured>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Insured FindById(int id)
        {
            try
            {
                return (from i in database.Insured
                        where i.Id == id
                        select i).FirstOrDefault<Insured>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Insured Delete(int id)
        {
            try
            {
                Insured insured = FindById(id);
                Insured deletedInsured = database.Insured.Remove(insured);
                database.SaveChanges();

                return deletedInsured;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}