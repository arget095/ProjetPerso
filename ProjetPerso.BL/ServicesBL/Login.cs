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
    public class Login
    {
        UserRepository service = new UserRepository();
        

        public int registration(UserBL entity)
        {
            User user = new User();
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.Pseudo = entity.Pseudo;
            user.Mail = entity.Mail;
            user.Password = entity.Password;

            user.Id = service.Create(user);
            return user.Id;
        }

        public void login(string pseudo,string password)
        {
            if (service.CheckUserByPseudoAndPassword(pseudo,password))
            {
                Console.WriteLine("je suis connecté");
            }
            else Console.WriteLine("Pseudo ou mot de passe incorrect");
        }

        public void disconect()
        {

        }
    }
}
