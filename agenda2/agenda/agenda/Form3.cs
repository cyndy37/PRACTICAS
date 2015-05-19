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
    public partial class ventana3 : Form
    {
        public MySqlConnection myConnection;

        public ventana3()
        {
            InitializeComponent();
            iniciaComponentes();
        }//constructor

        private void btnMain_Click(object sender, EventArgs e)
        {
            ventana ven = new ventana();
            this.Visible = false;
            ven.Visible = true;
        }//btnMain

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

        public void iniciaComponentes()
        {
            abrirConexion();
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            string query = "select nombre from usuarios";
            MySqlDataAdapter da = new MySqlDataAdapter(query, myConnection);
            //se indica el nombre de la tabla
            da.Fill(ds, "nombre");
            comboBox.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox.ValueMember = "nombre";
            cerrarConexion();
       }//inciaComponentes

        private void btnShow_Click(object sender, EventArgs e)
        {
            abrirConexion();
            string usuario = comboBox.SelectedValue.ToString();
            string query = "select * from usuarios where nombre = '"+ usuario +"'";
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string nombre = myReader["nombre"].ToString();
                string domicilio = myReader["domicilio"].ToString();
                string colonia = myReader["colonia"].ToString();
                string cp = myReader["cp"].ToString();
                string telefono = myReader["telefono"].ToString();
                string celular = myReader["celular"].ToString();
                string rfc = myReader["rfc"].ToString();
                string correo = myReader["correo"].ToString();
                txtNombre.Text = nombre;
                txtDomicilio.Text = domicilio;
                txtColonia.Text = colonia;
                txtCP.Text = cp;
                txtTelefono.Text = telefono;
                txtCelular.Text = celular;
                txtRFC.Text = rfc;
                txtCorreo.Text = correo;
            }//while
            myReader.Close();
            myReader = null;
            myCommand.Dispose();
            myCommand = null;
            cerrarConexion();
        }//btnShow
    }//class
}//namespace
