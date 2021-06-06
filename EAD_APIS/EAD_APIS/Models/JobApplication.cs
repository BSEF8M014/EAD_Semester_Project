using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_APIS.Models
{
    public partial class JobApplication
    {
        public int JobApplicationId { get; set; }
        public int? SeekerId { get; set; }
        public int? JobId { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Job Job { get; set; }
        public virtual Seeker Seeker { get; set; }
    }
}
