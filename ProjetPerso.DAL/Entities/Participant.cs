using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetPerso.DAL.Interfaces;

namespace ProjetPerso.DAL.Entities
{
    public class Participant : IEntity<int>
    {
        public int Id { get; set;}
        public int IdUser { get; set; }
        public int IdEvent { get; set; }        
    }
}
