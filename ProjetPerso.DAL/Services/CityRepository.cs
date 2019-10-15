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
    public class CityRepository
    {
        private Connection _Connection { get; set; }

        public CityRepository()
        {
            #region sql formation
            /*_Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=",
                "System.Data.SqlClient");*/
            #endregion
            #region sql maison
            _Connection = new Connection(@"Data Source = DESKTOP-8OP2MN3; Initial Catalog = ProjetPerso; Integrated Security = True", "System.Data.SqlClient");
            #endregion
        }

        public City Get(string cp)
        {
            Command cmd = new Command("SELECT * FROM City WHERE PostalCode = @pc");
            cmd.AddParameter("@pc", cp);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.CityMapper).SingleOrDefault();
        }

        public IEnumerable<City> GetAll()
        {
            Command cmd = new Command("SELECT * FROM City");

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.CityMapper);
        }
    }
}
