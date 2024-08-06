using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    public class persona  //Esta calse permite agregar, eliminar y modificar  los datos de un  usuario dentro de la tabla usuarios.
    {
        //Atributos
        
        public string codigoAsociado { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }

        //Constructor

        public persona(string codigoAsociado, string id, string nombre, string primerApellido, string segundoApellido)
        {

            this.codigoAsociado = codigoAsociado;
            this.id = id;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
        }

        //Metodos

        public void agregarPersona(string codigoAsociado, string  id, string nombre, string primerApellido, string segundoApellido) //Este metodo permite  agregar  un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string ingreso = "Insert into usuarios ([CodigoAsociado], [Id],[Nombre],[PrimerApellido],[SegundoApellido]) values('" + codigoAsociado + "','" + id + "','" + nombre + "','" + primerApellido + "','" + segundoApellido + "') ";
            SqlCommand comando = new SqlCommand(ingreso, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();




        }

        public void modificarPersona(string id, string nombre, string primerApellido, string segundoApellido) //Este metodo permite  modificar los datos (nombre, priemr apellido y segundo apellido) de un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string modificacion = "Update usuarios set  Nombre='" + nombre + "',   PrimerApellido='" + primerApellido + "', SegundoApellido='" + segundoApellido + "'   where Id= '" + id+ "'";
            SqlCommand comando = new SqlCommand(modificacion, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }
        public void eliminarPersona(string id) //Este metodo permite  eliminar los datos de un  usuario dentro de la tabla.
        {
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string eliminacion = "Delete from usuarios where Id= '" + id + "'";
            SqlCommand comando = new SqlCommand(eliminacion, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }



    }
}
