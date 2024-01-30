using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Driver : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? LicenseNo { get; set; }
        public virtual Car? Car{ get; set; }
        public int CarId { get; set; }

    }
}
