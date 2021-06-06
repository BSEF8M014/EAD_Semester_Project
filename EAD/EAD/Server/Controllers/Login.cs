using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAD.Server.Models;

namespace EAD.Server.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class Login : ControllerBase
    {
        public User getUserByUsernamePassword(string user_name, string user_pass)
        {
            var db = new job_portalContext();
            return  db.Users.ToList().Find(s => s.UserName == user_name && s.UserPass == user_pass);
        }
        [HttpGet]
        [Route("login")]
        public User Get()
        {
            var db = new job_portalContext();
            return getUserByUsernamePassword("wak327", "qwert");
        }

    }
}
