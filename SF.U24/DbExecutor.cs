﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SF.U24.Connector
{
    public class DbExecutor
    {
        

        private MainConnector connector;
        public DbExecutor(MainConnector connector)
        {
            this.connector = connector;
        }

        public DataTable SelectAll(string table)
        {
            var selectcommandtext = "select * from " + table;
            var adapter = new SqlDataAdapter(
              selectcommandtext,
              connector.GetConnection()
            );
            var ds = new DataSet();
            adapter.Fill(ds);

            return ds.Tables[0]; 
        }
    }
}
