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
            //User nicolas = new User();
            //UserRepository service = new UserRepository();
            //nicolas.Pseudo = "tasoeur";
            //nicolas.FirstName = "oceane";
            //nicolas.LastName = "calloens";
            //nicolas.Password = "test1234=";
            //nicolas.Mail = "oceane.calloens@hotmail.com";

            //nicolas.Id = service.Create(nicolas);

            //Console.WriteLine(nicolas.Id);
            //nicolas = service.Get(1);

            //foreach (var item in service.GetAll())
            //{
            //    nicolas = item;
            //    Console.WriteLine(nicolas.Pseudo);
            //}

            //Console.WriteLine(nicolas.LastName);
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

            Event even = new Event();
            User moi = new User();
            Country pays = new Country();
            City hunter = new City();
            Loisir activite = new Loisir();

            UserRepository userserv = new UserRepository();
            EventRepository eventserv = new EventRepository();
            CountryRepository countryserv = new CountryRepository();
            CityRepository cityserv = new CityRepository();
            LoisirRepository loisirserv = new LoisirRepository();

            //moi = userserv.Get(1);
            //pays = countryserv.Get("BEL");
            //hunter = cityserv.Get("4300");
            //activite = loisirserv.Get(8);

            //even.Admin = moi.Id;
            //even.Name = "MonPremierEvent";
            //even.Time = new DateTime(2019, 10, 11, 15, 30, 00);
            //even.IdCountry = pays.Id;
            //even.IdCityPostalCode = hunter.PostalCode;
            //even.IdLoisir = activite.IdLoisir;

            //even.Id = eventserv.Create(even);
            //Console.WriteLine(even.Id);


            even = eventserv.Get(15);

            Console.WriteLine(even.Name);
            #endregion

            Console.ReadKey();
        }
    }
}
