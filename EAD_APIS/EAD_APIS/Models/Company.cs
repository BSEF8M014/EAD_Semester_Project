using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_APIS.Models
{
    public partial class Company
    {
        public Company()
        {
            Jobs = new HashSet<Job>();
        }

        public int? UserId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
