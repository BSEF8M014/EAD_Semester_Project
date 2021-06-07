using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAD_APIS.Models;

namespace EAD_APIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public User Post()
        {
            job_portalContext db = new job_portalContext();
            string user_name = "wak327"; 
            string user_pass = "qwert";
            return db.Users.ToList().Find(s => s.UserName == user_name&& s.UserPass==user_pass);
        }
    }
    
}
