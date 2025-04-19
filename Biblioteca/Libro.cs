using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }

        //Construtor
        public Libro(string titulo, string autor, string editorial) { 
        
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
        }


    }





}
