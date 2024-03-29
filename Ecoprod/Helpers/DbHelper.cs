﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecoprod.Helpers;

internal class DbHelper
{
    private string connectParams = "datasource=127.0.0.1;port=3306;username=root;password=;database=Ecoprod;";
    private MySqlConnection connection;

    public DbHelper()
    {
        connection = new MySqlConnection(connectParams);
    }

    public int CountRecords(string query)
    {
        if (connection.State != ConnectionState.Open) connection.Open();
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataReader reader = command.ExecuteReader();
        int counter = 0;
        while (reader.Read()) counter++;
        connection.Close();
        return counter;
    }

    public void InsertRecord(string query)
    {
        if (connection.State != ConnectionState.Open) connection.Open();
        MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }

    public DataRow getSignelRecord(string query)
    {
        if (connection.State != ConnectionState.Open) connection.Open();
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        return ds.Tables[0].Rows[0];
        // https://metanit.com/sharp/adonet/3.6.php
    }


    public DataTable getRecords(string query)
    {
        if (connection.State != ConnectionState.Open) connection.Open();
        MySqlCommand command = new MySqlCommand(query, connection);
        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        connection.Close();
        return ds.Tables[0];
    }
}

