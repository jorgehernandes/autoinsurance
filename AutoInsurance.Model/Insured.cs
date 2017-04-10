using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.Model
{
    public class Insured
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Gender { get; set; }
    }
}