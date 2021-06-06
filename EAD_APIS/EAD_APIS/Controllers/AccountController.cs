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
        [HttpGet]
        [Route("login")]
        public List<User> Get()
        {
            job_portalContext db = new job_portalContext();
            return db.Users.ToList();

        }
    }
    
}
