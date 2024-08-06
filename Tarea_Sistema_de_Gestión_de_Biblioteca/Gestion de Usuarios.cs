using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    public partial class Gestion_de_Usuarios : Form
    {
        public Gestion_de_Usuarios()
        {
            InitializeComponent();
        }

        private void Gestion_de_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificarLibro_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string nombre = textBoxNombre.Text;
            string primerApellido = textBoxPrimerApellido.Text;
            string segundoApellido = textBoxSegundoApellido.Text;
            string codigoAsociado = "";

            persona actualizarPersona = new persona(codigoAsociado, id, nombre, primerApellido, segundoApellido);
            actualizarPersona.modificarPersona(id, nombre, primerApellido, segundoApellido);
           
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxPrimerApellido.Text = "";
            textBoxSegundoApellido.Text = "";


        }

        

        private void textBoxSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string nombre = textBoxNombre.Text;
            string primerApellido = textBoxPrimerApellido.Text;
            string segundoApellido= textBoxSegundoApellido.Text;
            string codigoAsociado = "";

            persona eliminarUsuario = new persona(codigoAsociado, id, nombre, primerApellido, segundoApellido);
            eliminarUsuario.eliminarPersona(id);
            textBoxId.Text = "";
            
        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
           MENU menuForm = new MENU();
            menuForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            string nombre = textBoxNombre.Text;
            string primerApellido = textBoxPrimerApellido.Text;
            string segundoApellido = textBoxSegundoApellido.Text;
            string codigoAsociado = textBoxCodigoAsociado.Text;

            persona nuevoUsuario = new persona(codigoAsociado, id, nombre, primerApellido, segundoApellido);
            nuevoUsuario.agregarPersona(codigoAsociado, id, nombre, primerApellido, segundoApellido);
            
            textBoxId.Text="";
            textBoxNombre.Text = "";
            textBoxPrimerApellido.Text = "";
            textBoxSegundoApellido.Text = "";
            textBoxCodigoAsociado.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoAsociado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
