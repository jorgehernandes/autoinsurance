using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;

namespace AutoInsurance.Data
{
    public class CarRepository
    {
        public bool Save(Car obj)
        {
            try
            {
                Database Database = new Database();

                Database.Car.Add(obj);
                Database.SaveChanges();

                return true;
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
                Database Database = new Database();

                return (from c in Database.Car
                        select c).ToList<Car>();
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
                Database database = new Database();

                return (from c in database.Car
                        where c.Id == Id
                        select c).FirstOrDefault<Car>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Car obj)
        {
            return true;
        }
    }
}