﻿using System.Data;
using Npgsql;
namespace parcial2
{
    public static class ConnectionDB
    {
        public static string Connection =
            "Server=localhost;Port=5432;User Id=postgres;Password=Strowyer117;Database=parcial;"; 
        public static DataTable ExecuteQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Connection);
            DataSet ds = new DataSet();
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        } 
        public static void Executenonquery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(Connection); 
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }   
    }
}