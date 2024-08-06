using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
   

    public partial class LOGIN : System.Windows.Forms.Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string validacion = "Select Count (*) From  usuarioAdministrador where Id= '" + textBoxUsuario.Text + "' and Contraseña = '" + textBoxContraseña.Text + "'";
            SqlCommand comando = new SqlCommand(validacion, conexion);
            comando.ExecuteNonQuery();
            
            int count = (int)comando.ExecuteScalar();

            if (count > 0)
            {
                MENU menuForm = new MENU();
                menuForm.Show();
                this.Hide();
                textBoxUsuario.Text = "";
                textBoxContraseña.Text = "";



            }

            else 
            {

                MessageBox.Show("Los datos ingresados no son validos.");
                textBoxUsuario.Text = "";
                textBoxContraseña.Text = "";

            }

            conexion.Close();


        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
