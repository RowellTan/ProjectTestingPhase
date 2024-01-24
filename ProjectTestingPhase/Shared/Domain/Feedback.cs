using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Feedback : BaseDomainModel
    {
        public virtual Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Driver? Driver { get; set; }
        public int DriverId { get; set; }
        public virtual Booking? Booking { get; set; }
        public int BookingId { get; set; }
        public string? Comments { get; set; }
        public DateTime Time { get; set; }
    }
}
