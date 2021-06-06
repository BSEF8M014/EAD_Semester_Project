using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_APIS.Models
{
    public partial class Seeker
    {
        public Seeker()
        {
            JobApplications = new HashSet<JobApplication>();
        }

        public int? UserId { get; set; }
        public int SeekerId { get; set; }
        public int? AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public int? JobResumeId { get; set; }

        public virtual Address Address { get; set; }
        public virtual JobResume JobResume { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
