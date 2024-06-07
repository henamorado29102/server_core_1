using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Coach : BaseDomainModel
    {
        public string? Name { get; set; }

        public int? TeamId { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Team? Team { get; set; }
    }
}