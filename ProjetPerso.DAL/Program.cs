﻿using ProjetPerso.DAL.Entities;
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
            #region create
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

            #endregion



            //Console.WriteLine(nicolas.LastName);
            Console.ReadKey();
        }
    }
}
