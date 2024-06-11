using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerService.DDD
{
    public interface IRepository<TEntity, TKey>
    {
        Task<TEntity> GetAsync(TKey id);
        Task<List<TEntity>> GetListAsync();
    }


}
