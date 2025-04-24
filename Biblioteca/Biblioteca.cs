using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;


namespace GestionBiblioteca
{
    internal class Biblioteca
    {
        //Lista para almacenar los libros
        private List<Libro> libros;//Lista de libros
        private List<Lector> lectores;//Lista de lectores

        //Constructor de la clase biblioteca
        public Biblioteca()
        {
            libros = new List<Libro>();//Inicia lista vacía, libros
            lectores = new List<Lector>();//Inicia lista vacía, lectores
        }

        //Método para agregar libros a la biblioteca
        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            //Existencia del libro
            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return false; //Libro existente
                }
            }
            //si no existe, se agrega
            libros.Add(new Libro(titulo, autor, editorial));
            return true;
        }


        //Método para buscar libro titulo
        public Libro BuscarLibro(string titulo)
        {
            //Recorre la lista de libros para buscar el que coincida
            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return libro; //Muestra el libro encontrado
                }
            }
            return null; //Si no lo encuentra
        }

        //Método para eliminar libro
        public bool EliminarLibro(string titulo)
        {
            //Busca el libro
            var libro = BuscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);//Si lo encuentra lo elimina
                return true;
            }
            return false; // si no lo encuentra, retorna false
        }
        
        
        //Método para listar los libros
        public void ListarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros"); // Muestra este mensaje si no hay libros
            }
            else
            {
                foreach (var libro in libros)
                {
                    //Si hay libros los lista
                    Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Editorial: {libro.Editorial}");
                }
            }
        }

        //Método para dar de alta un lector
        public bool AltaLector (string nombre,  string dni)
        {
            //Verificar existencia
            foreach (var lector in lectores)
            {
                if (lector.Dni == dni)
                {
                    Console.WriteLine($"El DNI n°{dni} ya se encuentra registrado");
                    return false; //El lector existe
                    
                }
            }
            //Si el lector no existe, lo agregamos al listado
            lectores.Add( new Lector(nombre, dni));
            return true;
        }

        //Método para listar los lectores
        public void ListarLectores()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay lectores"); // Muestra este mensaje si no hay lectores
            }
            else
            {
                foreach (var lector in lectores)
                {
                    //Si hay libros los lista
                    Console.WriteLine($"Lector: {lector.Nombre}, {lector.Dni}");
                }
            }
        }

        //Metodo para prestamos de libros
        public string PrestarLibro(string titulo, string dni)
        {
            // Buscar lector
            // Busca el primer lector con el que coincida el dni
            var lector = lectores.FirstOrDefault(l => l.Dni == dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE"; // Retornamos el mensaje si el lector no existe
            }

            // Buscar libro por título
            //Busca el primer libro con el que coincida el titulo
            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libro == null)
            {
                return "LIBRO INEXISTENTE"; // Retornamos el mensaje si el libro no existe
            }

            // Verificar si puede pedir préstamo
            if (!lector.PrestamoHabilitado())
            {
                return "TOPE DE PRESTAMO ALCAZADO"; // Retornamos el mensaje si el lector no puede pedir más libros
            }

            // Realizar préstamo
            lector.AgregarPrestamo(libro);
            libros.Remove(libro);

            return "PRESTAMO EXITOSO"; // Si todo salió bien, devolvemos el mensaje de éxito
        }





    }
}

