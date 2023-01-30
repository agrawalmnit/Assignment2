﻿
using Dapper;
using Assignment;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T,U>(string storedProcedure , U parameters, string connectionId = "Default")
        {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
        connection.Open();
        return await connection.QueryAsync<T> (storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

    public async Task SaveData<T> (string storedProcedure,T parameters, string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
        connection.Open();
        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

    }
}









