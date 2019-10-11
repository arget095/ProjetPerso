using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Interfaces;
using ProjetPerso.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox;

namespace ProjetPerso.DAL.Services
{
    public class EventRepository : IRepository<int,Event>
    {
        private Connection _Connection { get; set; }

        public EventRepository()
        {
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=",
                "System.Data.SqlClient");
        }

        public int Create(Event entity)
        {
            Command cmd = new Command("AddEvent", true);

            cmd.AddParameter("@Name",entity.Name);
            cmd.AddParameter("@Time",entity.Time);
            cmd.AddParameter("@Admin",entity.Admin);
            cmd.AddParameter("IdCountry",entity.IdCountry);
            cmd.AddParameter("IdCityPostalCode", entity.IdCityPostalCode);
            cmd.AddParameter("IdLoisir",entity.IdLoisir);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public Event Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Event WHERE IdEvent = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.EventMapper).SingleOrDefault();
        }

        public IEnumerable<Event> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Event");
            return _Connection.ExecuteReader(cmd, DbToEntityMapper.EventMapper);
        }

        public Event Update(Event entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Command cmd = new Command("DELETE FROM Event WHERE Id = @Id");
            cmd.AddParameter("@Id", id);

            _Connection.ExecuteNonQuery(cmd);
        }
    }
}
