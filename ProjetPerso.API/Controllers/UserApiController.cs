using ProjetPerso.API.Models;
using ProjetPerso.DAL.Entities;
using ProjetPerso.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetPerso.API.Controllers
{
    public class UserApiController : ApiController
    {
        UserRepository service = new UserRepository();
        
        public User Get(int id)
        {
            User user = service.Get(id);           
            return user;
        }
        
    }
}
