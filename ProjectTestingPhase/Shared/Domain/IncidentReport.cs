using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class IncidentReport : BaseDomainModel
    {
        public string? Name { get; set; }
        public int PhoneNo { get; set; }
        public virtual Driver? Driver { get; set; }
        public int DriverId { get; set; }
    }
}
