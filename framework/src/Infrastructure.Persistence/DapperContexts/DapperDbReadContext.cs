using CoreBoilerplate.Application.Abstractions.DapperContexts;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBoilerplate.Infrastructure.Persistence.DapperContexts
{
    //Read details about this implmentation in the interface cs file.
    public class DapperDbReadContext : IDapperDbReadContext
    {
        private readonly IDbConnection _dbConnection;

        public DapperDbReadContext(IConfiguration configuration)
        {
            //Create a seperate sql connection instance using the SqlConnection library.
            _dbConnection = new SqlConnection(configuration.GetConnectionString(PersistenceConstants.DefaultConnectionName));

            //TODO, add in commented code-snippets for MySQL, etc connections.
        }

        public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
        {
            return (await _dbConnection.QueryAsync<T>(sql, param, transaction)).AsList();
        }

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
        {
            return await _dbConnection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
        }

        public async Task<T> QuerySingleAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
        {
            return await _dbConnection.QuerySingleAsync<T>(sql, param, transaction);
        }
    }
}