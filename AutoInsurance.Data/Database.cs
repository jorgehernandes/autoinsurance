using AutoInsurance.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Data
{
    public class Database : DbContext
    {
        public DbSet<Insured> Insured { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Proposal> Proposal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
