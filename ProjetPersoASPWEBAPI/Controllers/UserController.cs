using ProjetPerso.BL.ServicesBL;
using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace ProjetPersoASPWEBAPI.Controllers
{
    public class UserController : ApiController
    {
        UserRepository service = new UserRepository();
        Login loginservice = new Login();

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return service.GetAll();
        }

        [HttpGet]
        public User Get(int id)
        {
            return service.Get(id);
        }      
    }
}
