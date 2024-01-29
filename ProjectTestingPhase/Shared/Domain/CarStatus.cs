using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class CarStatus : BaseDomainModel
    {
        public string? Status { get; set; }

        public int CarId { get; set; }  // Assuming CarId is an integer

        public virtual Car? Car { get; set; }
    }
}
