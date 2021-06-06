using System;
using System.Collections.Generic;

#nullable disable

namespace EAD.Server.Models
{
    public partial class JobResume
    {
        public JobResume()
        {
            Educations = new HashSet<Education>();
            Experiences = new HashSet<Experience>();
            Seekers = new HashSet<Seeker>();
        }

        public int JobResumeId { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Seeker> Seekers { get; set; }
    }
}
