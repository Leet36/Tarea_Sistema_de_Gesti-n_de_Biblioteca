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
    public partial class Prestamo_y_Devolucion_de_Libros : Form
    {
        public Prestamo_y_Devolucion_de_Libros()
        {
            InitializeComponent();
        }

        private void Prestamo_y_Devolucion_de_Libros_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonPrestar_Click(object sender, EventArgs e)
        {

            string codigoAsociado = textBoxCodigoAsociado.Text;
            string ISBN = textBoxISBN.Text;
            string fechaEntrega = textBoxFE.Text;
            string fechaDevolucion = textBoxFD.Text;

            prestamosDevoluciones prestaLibro = new prestamosDevoluciones(codigoAsociado, ISBN, fechaEntrega, fechaDevolucion);

            prestaLibro.prestarLibro(codigoAsociado, ISBN, fechaEntrega, fechaDevolucion);

            textBoxCodigoAsociado.Text = "";
            textBoxISBN.Text = "";
            textBoxFE.Text = "";
            textBoxFD.Text = "";






        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU menuForm = new MENU();
            menuForm.Show();
            this.Hide();
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            string codigoAsociado = textBoxCodigoAsociado.Text;
            string ISBN = textBoxISBN.Text;
            string fechaEntrega = textBoxFE.Text;
            string fechaDevolucion = textBoxFD.Text;

            prestamosDevoluciones devolverLibro = new prestamosDevoluciones(codigoAsociado, ISBN, fechaEntrega, fechaDevolucion);

            devolverLibro.devolverLibro(codigoAsociado, ISBN, fechaEntrega, fechaDevolucion);

            textBoxCodigoAsociado.Text = "";
            textBoxISBN.Text = "";
            textBoxFE.Text = "";
            textBoxFD.Text = "";
        }
    }
}
