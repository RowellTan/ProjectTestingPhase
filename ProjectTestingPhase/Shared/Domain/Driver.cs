﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Driver : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? ContactName { get; set; }
        public string? LicenseNo { get; set; }
        public virtual Booking? Booking { get; set; }
        public int BookingId { get; set; }

    }
}
