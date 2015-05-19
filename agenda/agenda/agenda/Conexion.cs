using System;
using MySql.Data.MySqlClient;


public class Conexion
{
    protected MySqlConnection myConnection;

    public Conexion()
    {
    }//constructor

    protected void abrirConexion()
    {
        string connectionString =
        "Server=localhost;" +
        "Database=agenda;" +
        "User ID=root;" +
        "Password=1234;" +
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