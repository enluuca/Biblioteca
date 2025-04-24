using System;

namespace GestionBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una nueva instancia de la biblioteca
            Biblioteca miBiblioteca = new Biblioteca();

            //Agregamos libros a la biblioteca
            miBiblioteca.AgregarLibro("Cien Años de Soledad", "Gabriel García Márquez", "Sudamericana");
            miBiblioteca.AgregarLibro("El Principito", "Antoine de Saint-Exupéry", "Emecé");
            miBiblioteca.AgregarLibro("It", "Stephen King", "Viking Press");
            miBiblioteca.AgregarLibro("Don Quijote de la Mancha", "Miguel de Cervantes", "Francisco de Robles");
            miBiblioteca.AgregarLibro("Martín Fierro", "José Hernández", "Editorial Losada");
            

            // Listamos los libros de la biblioteca
            Console.WriteLine("Lista de libros:");
            miBiblioteca.ListarLibros();
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");

            // Registramos nuevos lectores
            Console.WriteLine("Alta lectores:");
            miBiblioteca.AltaLector("Juan Pérez", "12345678");
            miBiblioteca.AltaLector("Ana García", "23456789");
            miBiblioteca.AltaLector("Carlos López", "34567890");
            miBiblioteca.AltaLector("Juan López", "34567890");

            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Lista de lectores:");
            miBiblioteca.ListarLectores();
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");


            // Realizamos un prestamo
            Console.WriteLine("Préstamo de libros:");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nLector Juan Perez");
            //Juan Pérez quiere prestar "El Principito"
            string resultado = miBiblioteca.PrestarLibro("El Principito", "12345678");
            Console.WriteLine(resultado);  //"PRESTAMO EXITOSO"           
            resultado = miBiblioteca.PrestarLibro("Martín Fierro", "12345678");
            Console.WriteLine(resultado);  //"PRESTAMO EXITOSO"
            resultado = miBiblioteca.PrestarLibro("It", "12345678");
            Console.WriteLine(resultado);  //"PRESTAMO EXITOSO"
            resultado = miBiblioteca.PrestarLibro("Cien Años de Soledad", "12345678");
            Console.WriteLine(resultado);  //"TOPE DE PRESTAMO ALCAZADO"
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nLector Ana García");
            //Ana García quiere prestar "Don Quijote de la Mancha"
            resultado = miBiblioteca.PrestarLibro("Don Quijote de la Mancha", "23456789");
            Console.WriteLine(resultado);  //"PRESTAMO EXITOSO"
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nLector Carlos Lopez");
            //Carlos López quiere prestar un libro que no existe
            resultado = miBiblioteca.PrestarLibro("El libro de la selva", "34567890");
            Console.WriteLine(resultado);  // Debería ser "LIBRO INEXISTENTE"
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n");
            //Listamos los libros
            Console.WriteLine("\nLista actualizada de libros:");
            miBiblioteca.ListarLibros();
            Console.WriteLine("----------------------------------");

        }
    }
}
