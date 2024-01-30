using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class CarStatus : BaseDomainModel
    {
        public virtual Car? Car { get; set; }
        public string? CarId { get; set; }
        public string? Status { get; set; }
    }
}
