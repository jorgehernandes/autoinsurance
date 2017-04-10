namespace AutoInsurance.Data.Migrations
{
    using AutoInsurance.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoInsurance.Data.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AutoInsurance.Data.Database context)
        {
            context.Car.AddOrUpdate(
            new Car()
            {
                Id = 1,
                Manufacturer = "TATA Motors",
                Model = "Pixel",
                Year = 2013,
                Photo = "http://stopmensonges.com/wp-content/uploads/2014/01/Tata-Pixel-image-4-big-1024x768.jpg"
            },
            new Car()
            {
                Id = 2,
                Manufacturer = "Fiat",
                Model = "Bravo",
                Year = 2009,
                Photo = "https://automobile-assets.s3.amazonaws.com/automobile/body/10688667.jpg"
            },
            new Car()
            {
                Id = 3,
                Manufacturer = "Volkswagen",
                Model = "Fusca",
                Year = 1995,
                Photo = "http://2.bp.blogspot.com/-Bgk2FrkpmhI/UcYILHwMS3I/AAAAAAAAAsQ/fD3R5bWtD20/s400/fusca9.jpg"
            }
            );
            
        }
    }
}
