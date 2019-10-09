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
            User nicolas = new User();
            UserRepository service = new UserRepository();

            //nicolas.Pseudo = "arget095";
            //nicolas.FirstName = "nicolas";
            //nicolas.LastName = "agro";
            //nicolas.Password = "test1234=";
            //nicolas.Mail = "nicolas.agro@hotmail.com";


            //nicolas.Id = service.Create(nicolas);


            service.Get(1);
            Console.WriteLine("je suis le meillieur");
            Console.ReadKey();
        }
    }
}
