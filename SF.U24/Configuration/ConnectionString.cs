using System;
using Microsoft.Data.SqlClient;

namespace SF.U24
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"server=.\SQLEXPRESS;Database=SFU24;Trust Server Certificate=True; Trusted_Connection=True";
    }

}
