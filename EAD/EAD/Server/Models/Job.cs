using System;
using System.Collections.Generic;

#nullable disable

namespace EAD.Server.Models
{
    public partial class Job
    {
        public Job()
        {
            JobApplications = new HashSet<JobApplication>();
        }

        public int JobId { get; set; }
        public int? CompanyId { get; set; }
        public string JobTilte { get; set; }
        public string JobDesc { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}
