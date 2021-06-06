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
        [Route("login/{user_name}/{user_pass}")]
        public User Post(string user_name,string user_pass)
        {
            job_portalContext db = new job_portalContext();
            return db.Users.ToList().Find(s => s.UserName == user_name&& s.UserPass==user_pass);
        }
    }
    
}
