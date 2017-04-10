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
        public bool Save(Insured obj)
        {
            try
            {
                Database dataBase = new Database();

                dataBase.Insured.Add(obj);
                dataBase.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Insured> FindAll()
        {
            List<Insured> insuredList = new List<Insured>();

            try
            {
                Database database = new Database();

                return (from i in database.Insured 
                        select i).ToList<Insured>();
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
                Database dataBase = new Database();
                return (from i in dataBase.Insured
                        where i.Id == Id
                        select i).FirstOrDefault<Insured>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Insured obj)
        {
            return true;
        }
    }
}