using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox;

namespace ProjetPerso.DAL.Services
{
    public class CountryRepository
    {
        private Connection _Connection { get; set; }

        public CountryRepository()
        {
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=",
                "System.Data.SqlClient");
        }

        public Country Get(string id)
        {
            Command cmd = new Command("SELECT * FROM Country WHERE IdCountry = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.CountryMapper).SingleOrDefault();
        }

        public IEnumerable<Country> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Country");

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.CountryMapper);
        }
    }
}
