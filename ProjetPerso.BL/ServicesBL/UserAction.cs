using ProjetPerso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.BL.ServicesBL
{
    
    public class UserAction
    {
        UserRepository service = new UserRepository();

        public void UpdateMail(string pseudo,string mail)
        {
            service.UpdateMail(pseudo, mail);
        }

        public void UpdatePassword(string pseudo, string password)
        {
            service.UpdateMail(pseudo, password);
        }
    }
}
