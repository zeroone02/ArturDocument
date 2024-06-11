using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerService.DDD
{
    public interface IDapperDbContext
    {
        Task<IDbConnection> GetConnectionAsync();
    }
}
