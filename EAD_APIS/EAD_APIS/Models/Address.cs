using System;
using System.Collections.Generic;

#nullable disable

namespace EAD_APIS.Models
{
    public partial class Address
    {
        public Address()
        {
            Seekers = new HashSet<Seeker>();
        }

        public int AddressId { get; set; }
        public int? HouseNo { get; set; }
        public int? StreetNo { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Seeker> Seekers { get; set; }
    }
}
