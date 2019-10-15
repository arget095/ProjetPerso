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
    public class LoisirRepository
    {
        private Connection _Connection { get; set; }

        public LoisirRepository()
        {
            #region sql formation
            /*_Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=",
                "System.Data.SqlClient");*/
            #endregion
            #region sql maison
            _Connection = new Connection(@"Data Source = DESKTOP-8OP2MN3; Initial Catalog = ProjetPerso; Integrated Security = True", "System.Data.SqlClient");
            #endregion
        }

        public Loisir Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Loisir WHERE IdLoisir = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.LoisirMapper).SingleOrDefault();
        }

        public IEnumerable<Loisir> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Loisir");
            
            return _Connection.ExecuteReader(cmd, DbToEntityMapper.LoisirMapper);
        }
    }
}
