using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetPerso.DAL.Interfaces;

namespace ProjetPerso.DAL.Entities
{
    public class Event : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Participant { get; set; }
        public DateTime Time { get; set; }
        public int IdCountry { get; set; }
        public int IdCity { get; set; }
        public int Admin { get; set; }
        public int IdCategory { get; set; }
    }
}
