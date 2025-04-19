using System;

namespace GestionBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca miBiblioteca = new Biblioteca();

            // Agregarmos libros con el constructor
            miBiblioteca.AgregarLibro("Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana");
            miBiblioteca.AgregarLibro("El Principito", "Antoine de Saint-Exupéry", "Emecé");
            miBiblioteca.AgregarLibro("It", "Stephen King", "Viking Press");
            miBiblioteca.AgregarLibro("Don Quijote de la Mancha", "Miguel de Cervantes", "Francisco de Robles");

            // Listamos los libros
            Console.WriteLine("Lista de libros:");
            miBiblioteca.ListarLibros();

            // Buscamos un libro
            Console.WriteLine("Buscando 'El Principito':");
            var libro = miBiblioteca.BuscarLibro("El Principito");
            if (libro != null)
            {
                Console.WriteLine($"Encontrado: {libro.Titulo}, {libro.Autor}, {libro.Editorial}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado");
            }

            // Eliminamos un libro
            Console.WriteLine("Eliminando 'Cien Años de Soledad'");
            if (miBiblioteca.EliminarLibro("Cien Años de Soledad"))
            {
                Console.WriteLine("Eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar.");
            }

            // Listamos nuevamente
            Console.WriteLine("Lista actualizada de libros:");
            miBiblioteca.ListarLibros();
        }
    }
}
