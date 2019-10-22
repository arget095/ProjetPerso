using ProjetPerso.BL.EntityBL;
using ProjetPerso.BL.ServicesBL;
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

            service.login("arget095", "test1234=");


            Console.ReadKey();
        }
    }
}
