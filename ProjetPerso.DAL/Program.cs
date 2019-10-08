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
            User ci = new User();
            UserRepository service = new UserRepository();

            ci.Pseudo = "arget095";
            ci.FirstName = "ci";
            ci.LastName = "agro";
            ci.Password = "test1234=";
            ci.Mail = "ci.agro@hotmail.com";
            

            ci.Id = service.Create(ci);




            Console.ReadKey();
        }
    }
}
