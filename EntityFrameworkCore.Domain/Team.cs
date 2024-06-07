using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Team : BaseDomainModel
    {
        public string? Name { get; set; }

        public int LeagueId { get; set; }

        public string? CreatedBy { get; set; }        

        public string? ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Coach? Coach { get; set; }

        public virtual League League { get; set; } = null!;

        public virtual ICollection<Match> MatchAwayTeams { get; set; } = new List<Match>();

        public virtual ICollection<Match> MatchHomeTeams { get; set; } = new List<Match>();
    }
}