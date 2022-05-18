using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SF.U24.Connector
{
    public class MainConnector
    {

        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async void DisconnectAsync(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }
    }
}
