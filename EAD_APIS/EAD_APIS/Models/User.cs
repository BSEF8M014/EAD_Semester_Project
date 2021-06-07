using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_APIS.Models
{
    public partial class User
    {
        public User()
        {
            Companies = new HashSet<Company>();
            Seekers = new HashSet<Seeker>();
        }
        public User(string user_name,string user_pass,int type)
        {
            UserName = user_name;
            UserPass = user_pass;
            UserType = type;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public int? UserType { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Seeker> Seekers { get; set; }
    }
}
