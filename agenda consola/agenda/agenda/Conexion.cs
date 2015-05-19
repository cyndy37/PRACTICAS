using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace agenda
{
    class Conexion
    {
        protected MySqlConnection myConnection;

        public Conexion()
        {
 
        }//constructor

        protected void abrirConexion()
        {
            string connectionString =
            "Server=localhost;" +
            "Database=final;" +
            "User ID=root;" +
            "Password=;" +
            "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }//abrirConexion

        protected void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }//cerrarConexion
    }//class
}//namespace
