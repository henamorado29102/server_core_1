using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set;}
    }
}