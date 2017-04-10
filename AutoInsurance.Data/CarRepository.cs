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
        static readonly Database database = new Database();

        public bool Save(Car obj)
        {
            try
            {
                database.Car.Add(obj);
                database.SaveChanges();

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
                return (from c in database.Car
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
                return (from c in database.Car
                        where c.Id == Id
                        select c).FirstOrDefault<Car>();
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
                Car car = FindById(id);
                Car carDeleted = database.Car.Remove(car);
                database.SaveChanges();

                return carDeleted;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}