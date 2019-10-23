using ProjetPerso.BL.EntityBL;
using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.BL.ServicesBL
{
    public class EventGestion
    {
        EventRepository service = new EventRepository();
        ParticipantRepository serv = new ParticipantRepository();
        public int CreateEvent(EventBL entity)
        {
            Event even = new Event
            {
                Admin = entity.Admin,
                IdCityPostalCode = entity.IdCityPostalCode,
                IdCountry = entity.IdCountry,
                IdLoisir = entity.IdLoisir,
                Name = entity.Name,
                Time = entity.Time
            };

            return service.Create(even);
        }
        public void DeleteEvent(int idEvent,int admin)
        {
            service.Delete(idEvent,admin);
        }
        public void AddParticipant(ParticipantBL entity)
        {
            Participant participant = new Participant
            {
                IdEvent = entity.IdEvent,
                IdUser = entity.IdUser
            };
            serv.Create(participant);
        }
    }
}
