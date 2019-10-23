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
    public class ParticipantRepository
    {
        private Connection _Connection { get; set; }

        public ParticipantRepository()
        {
            #region sql formation
            _Connection = new Connection(@"Data Source=TECHNOBEL\;Initial Catalog=ProjetPerso;User ID=sa;Password=test1234=","System.Data.SqlClient");
            #endregion
            #region sql maison
            //_Connection = new Connection(@"Data Source = DESKTOP-8OP2MN3; Initial Catalog = ProjetPerso; Integrated Security = True", "System.Data.SqlClient");
            #endregion
        }

        public int Create(Participant entity)
        {
            EventRepository service = new EventRepository();
            Command cmd = new Command("AddParticipant", true);

            cmd.AddParameter("@IdEvent", entity.IdEvent);
            cmd.AddParameter("@IdUser", entity.IdUser);

            service.UpdateAuto(entity.IdEvent, true);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public Participant Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Participant WHERE Id = @Id");
            cmd.AddParameter("@Id", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.ParticipantMapper).SingleOrDefault();
        }

        public IEnumerable<Participant> GetAll(int id)
        {
            Command cmd = new Command("SELECT * FROM Participant WHERE IdEvent = @Id");
            cmd.AddParameter("@Id", id);
            return _Connection.ExecuteReader(cmd, DbToEntityMapper.ParticipantMapper);
        }

        public void Delete(int idevent, int iduser)
        {
            EventRepository service = new EventRepository();
            Command cmd = new Command("DELETE FROM Participant WHERE IdUser = @IdUser and IdEvent = @IdEvent");
            cmd.AddParameter("@IdEvent", idevent);
            cmd.AddParameter("@IdUser", iduser);

            service.UpdateAuto(idevent, false);
            _Connection.ExecuteNonQuery(cmd);
        }
        public int CreatePartiAuto(int idevent,int iduser)
        {
            Command cmd = new Command("AddParticipant", true);

            cmd.AddParameter("@IdEvent", idevent);
            cmd.AddParameter("@IdUser", iduser);

            return (int)_Connection.ExecuteScalar(cmd);
        }
        
        public void DeleteAuto(int idEvent)
        {
            Command cmd = new Command("DELETE FROM Participant WHERE IdEvent = @IdEvent");
            cmd.AddParameter("@IdEvent", idEvent);
            _Connection.ExecuteNonQuery(cmd);
        }
    }
}