using DocumentManagerService.DDD;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerService.DDD
{
    public abstract class DapperRepository<TEntity, TKey> : IRepository<TEntity, TKey>
    {
        public DapperRepository(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        protected IServiceProvider ServiceProvider { get; }

        protected IDapperDbContext GetDbContext() => ServiceProvider.GetRequiredService<IDapperDbContext>();
        protected Task<IDbConnection> GetDbConnectionAsync() => GetDbContext().GetConnectionAsync();

        public abstract Task<TEntity> GetAsync(TKey id);
        public abstract Task<List<TEntity>> GetListAsync();
    }
}
