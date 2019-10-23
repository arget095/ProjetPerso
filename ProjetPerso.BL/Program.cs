using ProjetPerso.BL.EntityBL;
using ProjetPerso.BL.ServicesBL;
using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.BL
{
    class Program
    {
        static void Main(string[] args)
        {

            Login service = new Login();

            service.Connect("arget095", "test1234=");

            Console.ReadKey();
        }
    }
}
