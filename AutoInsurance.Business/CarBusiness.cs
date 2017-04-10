using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Data;
using AutoInsurance.Model;

namespace AutoInsurance.Business
{
    public class CarBusiness
    {
        public bool Save(Car obj)
        {
            try
            {
                CarRepository repository = new CarRepository();
                return repository.Save(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Car> FindAll()
        {
            try
            {
                CarRepository repository = new CarRepository();
                return repository.FindAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Car FindById(int Id)
        {
            try
            {
                CarRepository repository = new CarRepository();
                return repository.FindById(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Car Delete(int id)
        {
            try
            {
                CarRepository repository = new CarRepository();
                return repository.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
