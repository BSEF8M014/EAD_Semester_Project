using System;
using System.Collections.Generic;

#nullable disable

namespace EAD.Server.Models
{
    public partial class Education
    {
        public int EducationId { get; set; }
        public int? JobResumeId { get; set; }
        public string Qualification { get; set; }

        public virtual JobResume JobResume { get; set; }
    }
}
