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
        [Route("Login/{user_name}_{user_pass}")]
        public string Post(string user_name,string user_pass)
        {
            job_portalContext db = new job_portalContext();
            //string user_name = "wak327"; 
            //string user_pass = "qwert";
            return $" {{\"userId\": {db.Users.ToList().Find(s => s.UserName == user_name&& s.UserPass==user_pass).UserId},\"userType\": {db.Users.ToList().Find(s => s.UserName == user_name&&s.UserPass==user_pass).UserType} }}";
        }
        //[HttpGet]
        //[Route("getSeeker{id}")]
        //public Seeker Get(int id)
        //{
        //    job_portalContext db = new job_portalContext();
        //    return db.Seekers.ToList().Find(s => s.UserId == id);
        //}
        [HttpGet]
        [Route("getSeekerName{id}")]
        public string Get(int id)
        {
            job_portalContext db = new job_portalContext();
            return db.Seekers.ToList().Find(s => s.UserId == id).FirstName;
        }
        [HttpPut]
        [Route("Reister/{user_name}_{user_pass}_{user_type}")]
        public string Put(string user_name,string user_pass,int user_type)
        {
            job_portalContext db = new job_portalContext();
            db.Users.Add(new User(user_name, user_pass, user_type));
 
            return "Added";
        }
    }
    
}
