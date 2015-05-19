using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace agenda
{
    public partial class ventana : Form
    {
        public MySqlConnection myConnection;

        public ventana()
        {
            InitializeComponent();
            iniciaComponentes();
        }//constructor

        public void abrirConexion()
        {
            string connectionString =
            "Server=localhost;" +
            "Database=final;" +
            "User ID=root;" +
            "Password=123456;" +
            "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }//abrirConexion

        public void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }//cerrarConexion

        public void iniciaComponentes(){
            abrirConexion();
            DataTable tabla = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter("select nombre, cp from usuarios", myConnection);
            mda.Fill(tabla);
            dgvDatos.DataSource = tabla;
            cerrarConexion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ventana2 ven2 = new ventana2();
            this.Visible = false;
            ven2.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ventana3 ven3 = new ventana3();
            this.Visible = false;
            ven3.Visible = true;
        }//iniciaComponentes 
    }//class
}//namespace
