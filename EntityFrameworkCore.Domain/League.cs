using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class League
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}