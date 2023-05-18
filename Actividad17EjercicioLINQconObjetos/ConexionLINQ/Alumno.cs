using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionLINQ
{
    internal class Alumno
    {
        public string idAlumno { get; set; }
        public string nameAlumno { get; set; }
        public string matricula { get; set; }
        public double promedio { get; set; }
        public string correo { get; set; }
        public int idCarrera { get; set; }

        public void getDatoAlumno()
        {
            Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera con ID {3}",
                nameAlumno, matricula, promedio, idCarrera);
        }
    }
}
