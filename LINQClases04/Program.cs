using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQClases04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de LINQ con clases

            // Creamos una lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0);
                new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0);
                new CEstudiante("Juan", "S875", "Programación Básica", 5.0);
                new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7);
                new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3);
                new CEstudiante("Alberto", "S456", "Orientado a objetos", 8.3);
            };

            // Encontramos los reprobados
            var reprobados = from estudiante in estudiantes
                             where estudiante.promedio <= 5.0 // Aqui trabajamos con una propiedad
                             select estudiante;

        }
    }
}
