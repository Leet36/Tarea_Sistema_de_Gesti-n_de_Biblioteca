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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_de_Libros gestionLibrosForm = new Gestion_de_Libros();
            gestionLibrosForm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buscador busquedaForm = new Buscador();
            busquedaForm.Show();
            this.Hide();
        }

       private void buttonGestionarUsuarios_Click(object sender, EventArgs e)
        {
            Gestion_de_Usuarios usuariosForm = new Gestion_de_Usuarios();
            usuariosForm.Show();
            this.Hide();
        }

        private void buttonPrestarDevolver_Click(object sender, EventArgs e)
        {
            Prestamo_y_Devolucion_de_Libros prestamosDevolucionesForm = new Prestamo_y_Devolucion_de_Libros();
            prestamosDevolucionesForm.Show();
            this.Hide();

        }
    }
}
