using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    class prestamosDevoluciones //Esta clase permite registrar en la tabla prestamosDevoluciones cuando se da en prestamo o se devuelve un libro.
    {
        //Atributos
        public string codigoAsociado { get; set; }
        public string ISBN { get; set; }
        public string fechaEntrega { get; set; }
        public string fechaDevolucion { get; set; }


        //Constructor

        public  prestamosDevoluciones(string codigoAsociado, string ISBN, string fechaEntrega, string fechaDevolucion) //Este metodo permite registrar en la tabla prestamosDevoluciones cuando se entrega en prestamo un libro.
        {

            this.codigoAsociado = codigoAsociado;
            this.ISBN = ISBN;
            this.fechaEntrega = fechaEntrega;
            this.fechaDevolucion = fechaDevolucion;
        }

     


        //Metodos

        public void prestarLibro(string codigoAsociado, string ISBN, string fechaEntrega, string fechaDevolucion) //Este metodo permite registrar en la tabla prestamosDevoluciones cuando un usuario hace la devolucion de un libro.
        {


            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string prestamo = "Insert into prestamosDevoluciones ( [CodigoAsociado],[ISBN],[fechaEntrega]) values('" + codigoAsociado + "','" + ISBN + "','" + fechaEntrega + "') ";
            string modificacion = "Update Libros set  Estado ='" + "En Prestamo" + "'   where ISBN= '" + ISBN + "'";
            SqlCommand comando = new SqlCommand(prestamo, conexion);
            SqlCommand comando1 = new SqlCommand(modificacion, conexion);

            comando.ExecuteNonQuery();
            comando1.ExecuteNonQuery();
            conexion.Close();
        }

        public void devolverLibro(string codigoAsociado, string ISBN, string fechaEntrega, string fechaDevolucion)
        {


            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string prestamo = "Insert into prestamosDevoluciones ( [CodigoAsociado],[ISBN],[fechaDevolucion]) values('" + codigoAsociado + "','" + ISBN + "','" + fechaDevolucion + "') ";
            string modificacion = "Update Libros set  Estado ='" + "Biblioteca" + "'   where ISBN= '" + ISBN + "'";
            SqlCommand comando = new SqlCommand(prestamo, conexion);
            SqlCommand comando1 = new SqlCommand(modificacion, conexion);

            comando.ExecuteNonQuery();
            comando1.ExecuteNonQuery();
            conexion.Close();
        }





    }
}
