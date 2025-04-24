using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBiblioteca;

namespace Biblioteca
{
    //Clase para representar al lector en la biblioteca
    internal class Lector
    {
        //Propiedad para guardar el nombre
        public string Nombre { get; set; }
        //Propiedad para guardar el dni
        public string Dni {  get; set; }
        //Propiedad para guardar el listado de libros
        public List<Libro> LibrosPrestados { get; set; }

        //Constructor para lector (Nombre, DNI) -> inicializa una lista de libros en 0
        public Lector (string nombre, string dni)
        {
            Nombre = nombre;
            Dni = dni;
            LibrosPrestados = new List<Libro> ();
        }

        //Método para indicar si el lector puede tomar otro prestamo
        public bool PrestamoHabilitado()
        {
            return LibrosPrestados.Count < 3;
        }

        //Metodo para agregar el libro al listado de prestamo
         public void AgregarPrestamo (Libro libro)
        {
            LibrosPrestados.Add (libro);
        }

    }
}
