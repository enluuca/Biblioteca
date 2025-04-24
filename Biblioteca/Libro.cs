using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca
{
    //Clase que representa al libro en la biblioteca
    internal class Libro
    {
        //Propiedad para guardar el titulo
        public string Titulo { get; set; }
        //Propiedad para guardar el autor
        public string Autor { get; set; }
        //Propiedad para guardar la editorial
        public string Editorial { get; set; }

        //Construtor para libros ( titulo, eutor y editorial)
        public Libro(string titulo, string autor, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
        }
    }

}
