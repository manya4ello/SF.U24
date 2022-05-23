using System;
using Microsoft.Data.SqlClient;

namespace SF.U24
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Data Source=.\SQLEXPRESS;Database=SFU24;Trusted_Connection=True;";
    }

}
