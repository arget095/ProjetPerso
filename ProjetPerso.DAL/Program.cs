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

            #region test userrepository
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
            //User nicolas = new User();
            //UserRepository service = new UserRepository();
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

            Console.ReadKey();
        }
    }
}
