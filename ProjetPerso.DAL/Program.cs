using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test avant event
            #region test userrepository
            UserRepository service = new UserRepository();
            User User1 = new User();

            //User1.Pseudo = "Draal";
            //User1.FirstName = "Robin";
            //User1.LastName = "fanari";
            //User1.Password = "test1234=";
            //User1.Mail = "robin.fanari@hotmail.com";

            //User1.Id = service.Create(User1);

            //Console.WriteLine(User1.Id);
            //Console.ReadKey();
            //Console.Clear();
            User1 = service.Get(7);

            //foreach (var item in service.GetAll())
            //{
            //    User1 = item;
            //    Console.WriteLine(User1.Password);
            //}

            Console.WriteLine(User1.LastName);
            #endregion
            #region test Countryrepository
            //Country pays = new Country();
            //CountryRepository service = new CountryRepository();

            //pays = service.Get("BEL");

            //Console.WriteLine(pays.Name);
            //Console.WriteLine(); Console.WriteLine();
            //foreach (var item in service.GetAll())
            //{
            //    pays = item;
            //    Console.WriteLine(pays.Name);
            //}

            #endregion
            #region test CityRepository
            //City ville = new City();
            //CityRepository service = new CityRepository();

            //ville = service.Get("1000");
            //Console.WriteLine(ville.Name);

            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var item in service.GetAll())
            //{
            //    ville = item;
            //    Console.WriteLine(ville.Name);
            //}
            #endregion
            #region test LoisirRepository
            //Loisir jeu = new Loisir();
            //LoisirRepository service = new LoisirRepository();

            //jeu = service.Get(3);

            //Console.WriteLine($"{jeu.Name} {jeu.NameCategory}");
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var item in service.GetAll())
            //{
            //    jeu = item;
            //    Console.WriteLine($"{jeu.Name} {jeu.NameCategory}");
            //}

            #endregion
            #region test CategoryRepository
            //Category gorie = new Category();
            //CategoryRepository service = new CategoryRepository();

            //gorie = service.Get(1);

            //Console.WriteLine(gorie.Name);
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var item in service.GetAll())
            //{
            //    gorie = item;
            //    Console.WriteLine(gorie.Name);
            //}

            #endregion
            #endregion
            #region test event

            //Event even = new Event();
            //User moi = new User();
            //Country pays = new Country();
            //City hunter = new City();
            //Loisir activite = new Loisir();

            //EventRepository eventserv = new EventRepository();
            //UserRepository userserv = new UserRepository();
            //CountryRepository countryserv = new CountryRepository();
            //CityRepository cityserv = new CityRepository();
            //LoisirRepository loisirserv = new LoisirRepository();

            //moi = userserv.Get(3);
            //pays = countryserv.Get("BEL");
            //hunter = cityserv.Get("1000");
            //activite = loisirserv.Get(1);

            //even.Admin = moi.Id;
            //even.Name = "MonPremierEventMaison";
            //even.Time = new DateTime(2019, 10, 16, 15, 30,00);
            //even.IdCountry = pays.Id;
            //even.IdCityPostalCode = hunter.PostalCode;
            //even.IdLoisir = activite.IdLoisir;

            //even.Id = eventserv.Create(even);
            //Console.WriteLine(even.Id);


            //even = eventserv.Get(1);

            //Console.WriteLine(even.Name);
            #endregion
            #region test Participant

            //User moi = new User();
            //Event eventt = new Event();
            //Participant parti = new Participant();

            //UserRepository userserv = new UserRepository();
            //EventRepository eventserv = new EventRepository();
            //ParticipantRepository partiserv = new ParticipantRepository();

            //moi = userserv.Get(5);
            //eventt = eventserv.Get(1);
            //Console.WriteLine(moi.Id);
            //parti.IdEvent = eventt.Id;
            //parti.IdUser = moi.Id;

            //partiserv.Create(parti);
            //parti = partiserv.Get(1);
            //Console.WriteLine(parti.Id);
            //foreach (var item in partiserv.GetAll(16))
            //{
            //    parti = item;
            //    Console.WriteLine($"{parti.Id} {parti.IdEvent} {parti.IdUser}");
            //}
            //partiserv.Delete(17, 4);
            #endregion

            Console.ReadKey();
        }
    }
}
