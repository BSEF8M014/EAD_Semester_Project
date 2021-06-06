using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_APIS.Models
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public int? JobResumeId { get; set; }
        public string Descriptions { get; set; }

        public virtual JobResume JobResume { get; set; }
    }
}
