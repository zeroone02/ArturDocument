using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerService.DDD
{
    public class DapperDbContext : IDapperDbContext
    {
        private readonly IConfiguration _configuration;
        public DapperDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<IDbConnection> GetConnectionAsync()
        {
            IDbConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("Default"));
            return Task.FromResult(connection);
        }
    }
}
