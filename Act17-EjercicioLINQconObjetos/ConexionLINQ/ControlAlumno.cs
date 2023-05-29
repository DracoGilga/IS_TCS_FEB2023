using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionLINQ
{
    internal class ControlAlumno
    {
        List<Carrera> carreraList = new List<Carrera>();
        List<Alumno> alumnoList = new List<Alumno>();

        public ControlAlumno()
        {
            carreraList.Add(new Carrera 
            { 
                idCarrera = 1, 
                nameCarrera = "ingenieria de software"
            });

            carreraList.Add(new Carrera 
            { 
                idCarrera = 2, 
                nameCarrera = "Redes y servicios de computo" 
            });

            alumnoList.Add(new Alumno 
            { 
                idAlumno = "1", 
                nameAlumno = "Juan perez sanchez", 
                matricula = "s17011675", 
                promedio = 8.9, 
                idCarrera = 1 
            });

            alumnoList.Add(new Alumno
            {
                idAlumno = "2",
                nameAlumno = "Pedro perez sanchez",
                matricula = "s17011676",
                promedio = 9.9,
                idCarrera = 2
            });

            alumnoList.Add(new Alumno
            {
                idAlumno = "3",
                nameAlumno = "Maria perez sanchez",
                matricula = "s17011677",
                promedio = 9.9,
                idCarrera = 3
            });
        }

        public void obtenerAlumnosPorCarrera(int idCarrera)
        {
        IEnumerable<Alumno> resultado = from alumno in alumnoList
                                        where alumno.idCarrera == idCarrera
                                        select alumno;
            foreach (Alumno alumno in resultado)
            {
                alumno.getDatoAlumno();
            }
        }

        public void obtenerAlumnosPorCarrera2(int idCarrera)
        {
            var resultado = from alumno in alumnoList
                            join carrera in carreraList on alumno.idCarrera equals carrera.idCarrera
                            where alumno.idCarrera == idCarrera
                            select new
                            {
                                Alumno = alumno,
                                NombreCarrera = carrera.nameCarrera
                            };

            foreach (var resultadoAlumno in resultado)
            {
                resultadoAlumno.Alumno.getDatoAlumno();
                Console.WriteLine("Carrera: {0}", resultadoAlumno.NombreCarrera);
            }
        }


    }
}
