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
        public bool Save(Proposal obj)
        {
            try
            {
                using (Database db = new Database())
                {
                    obj.Car = db.Car.FirstOrDefault<Car>(m => m.Id == obj.Car.Id);

                    db.Proposal.Add(obj);
                    db.SaveChanges();
                    return true;
                }
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
                using (Database database = new Database())
                {
                    return database.Proposal
                                   .Include("Car")
                                   .Include("Insured")
                                   .ToList<Proposal>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Proposal FindById(int Id)
        {
            return new Proposal();
        }

        public bool Delete(Proposal obj)
        {
            return true;
        }
    }
}