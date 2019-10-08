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
    public class ParticipantRepository : IRepository<int, Participant>
    {
        private Connection _Connection { get; set; }

        public ParticipantRepository()
        {
            _Connection = new Connection(@"Server=TECHNOBEL,Database=ProjetPerso,User Id=sa,Password=test1234=",
                "System.Data.SqlClient");
        }

        public int Create(Participant entity)
        {
            Command cmd = new Command("AddParticipant", true);

            cmd.AddParameter("@IdEvent", entity.IdEvent);
            cmd.AddParameter("@IdUser", entity.IdUser);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public Participant Get(int id)
        {
            Command cmd = new Command("SELECT * FROM Participant WHERE IdEvent = @IdEvent");//a corriger
            cmd.AddParameter("@IdEvent", id);

            return _Connection.ExecuteReader(cmd, DbToEntityMapper.ParticipantMapper).SingleOrDefault();
        }

        public IEnumerable<Participant> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Participant");
            return _Connection.ExecuteReader(cmd, DbToEntityMapper.ParticipantMapper);
        }

        public Participant Update(Participant entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Command cmd = new Command("SELECT * FROM Participant WHERE IdEvent = @IdEvent");//a corriger
            cmd.AddParameter("@IdEvent", id);

            _Connection.ExecuteNonQuery(cmd);
        }
    }
}