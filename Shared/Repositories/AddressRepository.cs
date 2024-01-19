using Dapper;
using Microsoft.Data.SqlClient;
using Shared.Entities;

namespace Shared.Repositories;

public class AddressRepository(string connectionString)
{
    private readonly string _connectionString = connectionString;

    public int Create(AddressEntity entity)
    {
        using var conn = new SqlConnection(_connectionString);
        var result = conn.ExecuteScalar<int>("", entity);

        return result;
    }
}
