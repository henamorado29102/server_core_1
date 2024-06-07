using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain.IRepository
{
    public interface IService
    {
        Task<IEnumerable<IRepository>> GetAll();
    }
}