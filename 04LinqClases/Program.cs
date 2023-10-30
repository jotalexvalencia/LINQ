using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LinqClases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CEstudiante> estudiantes = new List<CEstudiante> 
            { 
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientado a objetos",9.0),
                new CEstudiante("Juan","S875","Programacion basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","S456","Orientado a objetos",8.3)

            };

            // Encontramos a los reprobados
            var reprobados = from e in estudiantes
                             where e.Promedio <=5
                             select e;

            // mostramos
            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r);

            // mostramos solo un atributo de los encontrados por medio de la propiedad
            Console.WriteLine("Solo un atributo");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r.Nombre);

            // encontramos solo los nombre de los de mercadotecnia
            var mercadotecnia = from e in estudiantes
                                where e.Curso == "Mercadotecnia"
                                select e.Nombre;
            Console.WriteLine("Nombres de Mercadotecnia");
            foreach (string n in mercadotecnia)
                Console.WriteLine(n);

        }
    }
}
