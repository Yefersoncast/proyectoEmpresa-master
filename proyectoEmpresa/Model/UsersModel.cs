﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEmpresa.Model
{
    public class UsersModel
    {
        string connstring = "server=localhost; database=login; UID=root; password=";

        public string guardarDato(string query)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connstring);

            MySqlCommand comandDatabase = new MySqlCommand(query, mySqlConnection);
            comandDatabase.CommandTimeout = 60;

            try
            {
                mySqlConnection.Open();

                int numeroderespuesta = comandDatabase.ExecuteNonQuery();

                if (numeroderespuesta > -1)
                {
                    return "true";

                }
                mySqlConnection.Close();

            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "falce";


        }
    }
}
