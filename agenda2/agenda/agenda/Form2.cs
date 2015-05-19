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
    public partial class ventana2 : Form
    {
        public MySqlConnection myConnection;

        public ventana2()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ventana ven = new ventana();
            this.Visible = false;
            ven.Visible = true;
        }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre;
            string domicilio;
            string colonia;
            string cp;
            string telefono;
            string celular;
            string rfc;
            string mail;
            if (txtNombre.Text.Equals("") || txtDomicilio.Text.Equals("") || txtColonia.Text.Equals("") || txtCP.Text.Equals("") || txtTelefono.Text.Equals("") || txtCelular.Text.Equals("") || txtRFC.Text.Equals("") || txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            else
            {
                nombre = txtNombre.Text;
                domicilio = txtDomicilio.Text;
                colonia = txtColonia.Text;
                cp = txtCP.Text;
                telefono = txtTelefono.Text;
                celular = txtCelular.Text;
                rfc = txtRFC.Text;
                mail = txtCorreo.Text;
                
                abrirConexion();

                string query = "insert into usuarios values('"+ nombre +"','"+ domicilio +"','"+ colonia +"','"+ cp + "','"+ telefono +"','"+ celular +"','"+ rfc +"','"+ mail +"')";
                MySqlCommand myCommand = new MySqlCommand(query, myConnection);
                int result = myCommand.ExecuteNonQuery();
                myCommand.Dispose();
                myCommand = null;
                if (result > 0)
                    MessageBox.Show("Nuevo usuario insertado");
                cerrarConexion();
                txtNombre.Text = "";
                txtDomicilio.Text = "";
                txtColonia.Text = "";
                txtCP.Text = "";
                txtTelefono.Text = "";
                txtCelular.Text = "";
                txtRFC.Text = "";
                txtCorreo.Text = "";
            }//
        }//constructor
    }//class
}//namespace
