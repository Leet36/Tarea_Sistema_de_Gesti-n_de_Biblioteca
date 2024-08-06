using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            MENU menuForm = new MENU();
            menuForm.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Buscador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBusquedaLibros_Click(object sender, EventArgs e)
        {

            if (radioButtonISBN.Checked) //Mediante el uso de tres radio button, se condiciona la funcion "Busqueda", permitiendo al usuario  elegir entre "ISBN", "Titulo" o "Autor", al momento de realizar una busqueda
            {

                string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
                SqlConnection conexion = new SqlConnection(conexionstring);
                conexion.Open();
                string consulta = "Select * From  Libros where ISBN = '" + textBoxBusquedaLibros.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter dataId = new SqlDataAdapter(comando);
                DataTable tablaId = new DataTable();
                dataId.Fill(tablaId);
                dataGridViewConsultaLibros.DataSource = tablaId;
                conexion.Close();
            }

            else if (radioButtonAutor.Checked)
            {
                string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
                SqlConnection conexion = new SqlConnection(conexionstring);
                conexion.Open();
                string consulta = "Select * From  Libros where Autor = '" + textBoxBusquedaLibros.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter dataId = new SqlDataAdapter(comando);
                DataTable tablaId = new DataTable();
                dataId.Fill(tablaId);
                dataGridViewConsultaLibros.DataSource = tablaId;
                conexion.Close();


            }

            else if (radioButtonTitulo.Checked)
            {
                string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
                SqlConnection conexion = new SqlConnection(conexionstring);
                conexion.Open();
                string consulta = "Select * From  Libros where Titulo = '" + textBoxBusquedaLibros.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter dataId = new SqlDataAdapter(comando);
                DataTable tablaId = new DataTable();
                dataId.Fill(tablaId);
                dataGridViewConsultaLibros.DataSource = tablaId;
                conexion.Close();


            }
            

        }

        private void textBoxBusquedaLibros_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Medainete esta funcion el usuario podra realizar una busqueda global. 
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string consulta = "Select * From  Libros";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter dataId = new SqlDataAdapter(comando);
            DataTable tablaId = new DataTable();
            dataId.Fill(tablaId);
            dataGridViewConsultaLibros.DataSource = tablaId;
            conexion.Close();
        }
    }
}
