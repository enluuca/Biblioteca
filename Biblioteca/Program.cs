using System;

namespace GestionBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca miBiblioteca = new Biblioteca();

            // Agregamos algunos libros
            miBiblioteca.AgregarLibro("Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana");
            miBiblioteca.AgregarLibro("El Principito", "Antoine de Saint-Exupéry", "Emecé");

            // Listamos los libros
            Console.WriteLine("📚 Lista de libros:");
            miBiblioteca.ListarLibros();

            // Buscamos un libro
            Console.WriteLine("\n🔍 Buscando 'El Principito':");
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
            Console.WriteLine("\n🗑 Eliminando 'Cien Años de Soledad'");
            if (miBiblioteca.EliminarLibro("Cien Años de Soledad"))
            {
                Console.WriteLine("Eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar.");
            }

            // Listamos nuevamente
            Console.WriteLine("\n📚 Lista actualizada de libros:");
            miBiblioteca.ListarLibros();
        }
    }
}
