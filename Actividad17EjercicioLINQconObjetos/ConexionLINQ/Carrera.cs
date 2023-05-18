using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionLINQ
{
    internal class Carrera
    {
        public int idCarrera { get; set; } 
        public string nameCarrera { get; set;}

        public void getDatosCarrera()
        {
            Console.WriteLine("Carrera {0}, con ID {1}", nameCarrera, idCarrera);
        }
    }
}
