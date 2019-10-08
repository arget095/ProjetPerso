using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetPerso.DAL.Interfaces;
namespace ProjetPerso.DAL.Entities
{
    public class Country : IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
