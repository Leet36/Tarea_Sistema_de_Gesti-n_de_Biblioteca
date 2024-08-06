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
    public partial class Gestion_de_Libros : Form
    {
        public Gestion_de_Libros()
        {
            InitializeComponent();
        }

        private void Gestion_de_Libros_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

      


        }

        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            string ISBN =textBoxISBN.Text ;
            string Titulo = textBoxTitulo.Text;
            string Autor = textBoxAutor.Text;
            string Editorial = textBoxEditorial.Text;
            string Año = textBoxAño.Text;
            string Edicion = textBoxEdicion.Text;

            CRUDLibros agregarLibro = new CRUDLibros(ISBN, Titulo, Autor, Editorial, Año,  Edicion);
            agregarLibro.agregarLibro(ISBN, Titulo, Autor, Editorial, Año, Edicion);

            textBoxISBN.Text = "";
            textBoxTitulo.Text = "";
            textBoxAutor.Text = "";
            textBoxEditorial.Text = "";
            textBoxAño.Text = "";
            textBoxEdicion.Text = "";

        }

        private void buttonModificarDatos_Click(object sender, EventArgs e)
        {

            string ISBN = textBoxISBN.Text;
            string Titulo = textBoxTitulo.Text;
            string Autor = textBoxAutor.Text;
            string Editorial = textBoxEditorial.Text;
            string Año = textBoxAño.Text;
            string Edicion = textBoxEdicion.Text;

            CRUDLibros modificarLibro = new CRUDLibros(ISBN, Titulo, Autor, Editorial, Año, Edicion);
            modificarLibro.modificarLibro(ISBN, Titulo, Autor, Editorial, Año, Edicion);

            textBoxISBN.Text = "";
            textBoxTitulo.Text = "";
            textBoxAutor.Text = "";
            textBoxEditorial.Text = "";
            textBoxAño.Text = "";
            textBoxEdicion.Text = "";
        }

        private void buttonEliminarLibro_Click(object sender, EventArgs e)
        {
            string ISBN = textBoxISBN.Text;
            string Titulo = textBoxTitulo.Text;
            string Autor = textBoxAutor.Text;
            string Editorial = textBoxEditorial.Text;
            string Año = textBoxAño.Text;
            string Edicion = textBoxEdicion.Text;


            CRUDLibros eliminarLibro = new CRUDLibros(ISBN, Titulo, Autor, Editorial, Año, Edicion);
            eliminarLibro.eliminarLibro(ISBN);

            textBoxISBN.Text = "";
            textBoxTitulo.Text = "";
            textBoxAutor.Text = "";
            textBoxEditorial.Text = "";
            textBoxAño.Text = "";
            textBoxEdicion.Text = "";



        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            MENU menuForm = new MENU();
            menuForm.Show();
            this.Hide();

        }
    }
}
