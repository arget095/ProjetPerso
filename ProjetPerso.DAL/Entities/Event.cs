using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.DAL.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Participant { get; set; }
        public DateTime Time { get; set; }
        public string IdCountry { get; set; }
        public string IdCityPostalCode { get; set; }
        public int Admin { get; set; }
        public int IdLoisir { get; set; }
    }
}
