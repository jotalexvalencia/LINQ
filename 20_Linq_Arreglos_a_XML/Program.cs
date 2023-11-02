using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Necesario
using System.Xml.Linq;

namespace _20_Linq_Arreglos_a_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un XML a partir de un arreglo
            // funciona con otros contenedores tambien

            // Usamos tipos anonimos pero funciona con clases normales tambien

            var listado = new[]
            {
                new {Nombre="Jose", Calif=8, Curso="Programacion"},
                new {Nombre="Susana", Calif=9, Curso="UML"},
                new {Nombre="Maria", Calif=10, Curso="Orientado a objetos"},
                new {Nombre="Luis", Calif=10, Curso="UML"}
            };

            // Ahora creamos el elemento
            XElement alumnos = new XElement("Alumnos", // Este es la raiz
                from a in listado
                select new XElement("Alumno", new XAttribute("Nombre", a.Nombre),
                        new XElement("Curso", a.Curso),
                        new XElement("Calificacion", a.Calif)
                        )// fin de alumno
                );// fin de alumnos

            // Lo mostramos
            Console.WriteLine(alumnos);

            // Lo mandamos a disco
            alumnos.Save("Alumnos.xml");

            // Obtenemos informacion XML a partir de una cadena
            string alumnos2 = @"<Alumnos>
            <Alumno Nombre = 'Jose'>
            <Curso> Programacion </Curso>
            <Calificacion> 8 </Calificacion>
            </Alumno>
            <Alumno Nombre = 'Susana'>
            <Curso> UML </Curso>
            <Calificacion> 9 </Calificacion>
            </Alumno>
            <Alumno Nombre = 'Maria'>
            <Curso> Orientado a objetos </Curso>
            <Calificacion> 10 </Calificacion>
            </Alumno>
            <Alumno Nombre = 'Luis'>
            <Curso> UML </Curso>
            <Calificacion> 10 </Calificacion>
            </Alumno>
            </Alumnos>
            ";

            XElement alumnosx = XElement.Parse(alumnos2); // PAsamos la cadena para que haga parse

            // Mostramos el xml
            Console.WriteLine(alumnosx);
        }
    }
}
