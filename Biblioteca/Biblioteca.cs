using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca
{
    internal class Biblioteca
    {
        //Lista para almacenar los libros
        private List<Libro> libros;

        //Constructor de la clase biblioteca
        public Biblioteca()
        {
            libros = new List<Libro>();//Inicia lista vacía
        }

        //Agregar libros a la biblioteca
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


        //Buscar libro titulo
        public Libro BuscarLibro(string titulo)
        {
            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return libro; //Muestra el libro encontrado
                }
            }
            return null; //Si no lo encuentra
        }

        //Eliminar libro
        public bool EliminarLibro(string titulo)
        {
            var libro = BuscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);//Si lo encuentra lo elimina
                return true;
            }
            return false; // si no lo encuentra
        }
        
        
        //Lista de libros
        public void ListarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros");
            }
            else
            {
                foreach (var libro in libros)
                {
                    Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Editorial: {libro.Editorial}");
                }
            }
        }

    }
}

