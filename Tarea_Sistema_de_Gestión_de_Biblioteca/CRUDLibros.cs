using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Tarea_Sistema_de_Gestión_de_Biblioteca
{
    class CRUDLibros //Por medio de esta clase se busca poder, agregar, eliminar y actualizar, lo correspondiente a libors que se incluiran en la base de datos, se omite la busqueda ya para dicha funcion se elaboro un metodo fuera de la clase.
    {
        //Atributos

        public  string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Año { get; set; }
        public string Edicion { get; set; }
        public string Estado { get; set; }

        // Constructor


        public CRUDLibros(string ISBN, string Titulo, string Autor, string Editorial, string Año, string Edicion)
        {
            this.ISBN = ISBN;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Editorial = Editorial;
            this.Año= Año;
            this.Edicion = Edicion;
            

        }

        //Metodos

        public void agregarLibro(string ISBN, string Titulo, string Autor, string Editorial, string Año, string Edicion) // Metodo para poder agregar un libro a la base de datos en la tabla denominada "Libros"
        {
            int flag = 0;
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string ingreso = "Insert into Libros ( [ISBN],[Titulo],[Autor],[Editorial],[Año],[Edicion] ) values('" + ISBN + "','" + Titulo + "','" + Autor + "','" + Editorial + "','" + Año + "','" + Edicion + "') ";
            SqlCommand comando = new SqlCommand(ingreso, conexion);
            flag=comando.ExecuteNonQuery();

            conexion.Close();

        }

        public void eliminarLibro(string ISBN) // Metodo para eliminar un libro de la base de datos en la tabla denominada "Libros"
        {
            
            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string eliminacion = "Delete from Libros where ISBN= '" + ISBN + "'";
            SqlCommand comando = new SqlCommand(eliminacion, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
           
        }

        public void modificarLibro(string ISBN, string Titulo, string Autor, string Editorial, string Año, string Edicion) // Metodo para modificar  libro de la base de datos en la tabla denominada "Libros"
        {

            string conexionstring = "server=DESKTOP-IMN5G8G\\SQLEXPRESS01; database=SistemaGestionBiblioteca; Integrated security= True";
            SqlConnection conexion = new SqlConnection(conexionstring);
            conexion.Open();
            string modificacion = "Update Libros set  Titulo='" + Titulo + "',   Autor='" + Autor + "', Editorial='" + Editorial + "', Año='" + Año + "', Edicion='" + Edicion + "'   where ISBN= '" + ISBN + "'";
            SqlCommand comando = new SqlCommand(modificacion, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

        }





    }
}
