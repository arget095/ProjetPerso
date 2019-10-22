using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjetPerso.DAL.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }
        public string IdCountry { get; set; }
    }
}
