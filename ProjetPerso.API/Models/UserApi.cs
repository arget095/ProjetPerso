using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPerso.API.Models
{
    public class UserApi
    {
            public int Id { get; set; }
            public string Pseudo { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }
            public string Mail { get; set; }
    }
}