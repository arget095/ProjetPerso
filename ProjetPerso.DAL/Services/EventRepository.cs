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
    public class EventRepository
    {
        private Connection _Connection { get; set; }

        public EventRepository()
        {
            #region sql formation
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=","System.Data.SqlClient");
            #endregion
            #region sql maison
            //_Connection = new Connection(@"Data Source = DESKTOP-8OP2MN3; Initial Catalog = ProjetPerso; Integrated Security = True", "System.Data.SqlClient");
            #endregion
        }

        public int Create(Event entity)
        {
            ParticipantRepository service = new ParticipantRepository();
            Command cmd = new Command("AddEvent", true);

            cmd.AddParameter("@Name",entity.Name);
            cmd.AddParameter("@Time",entity.Time);
            cmd.AddParameter("@Admin",entity.Admin);
            cmd.AddParameter("IdCountry",entity.IdCountry);
            cmd.AddParameter("IdCityPostalCode", entity.IdCityPostalCode);
            cmd.AddParameter("IdLoisir",entity.IdLoisir);

            int id = (int)_Connection.ExecuteScalar(cmd);

            service.CreatePartiAuto(id,entity.Admin);
            return id;
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

        public void UpdateAuto(int id,bool actif)
        {
            Event entity = Get(id);
            Command cmd = new Command("Update Event Set Participant = @plus_un WHERE IdEvent = @Id");
            if (actif)
            {
                entity.Participant++;             
                cmd.AddParameter("@plus_un", entity.Participant);
                cmd.AddParameter("@Id", id);
            }
            else if (!actif)
            {
                entity.Participant--;
                cmd.AddParameter("@plus_un", entity.Participant);
                cmd.AddParameter("@Id", id);
            }
            _Connection.ExecuteNonQuery(cmd);
        }

        public void Delete(int id,int iduser)
        {
            ParticipantRepository service = new ParticipantRepository();
            Command cmd = new Command("DELETE FROM Event WHERE IdEvent = @Id and Admin = @Iduser");
            cmd.AddParameter("@Id", id);
            cmd.AddParameter("@Iduser", iduser);

            service.DeleteAuto(id);
            _Connection.ExecuteNonQuery(cmd);
        }
    }
}
