using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrayListTips
{
    class Program
    {
        static void Main(string[] args)
        {
            // tips para el uso de ArrayList con LINQ por medio de OfType<>

            // Seleccionamos objetos de un tipo en particular que esten en un ArrayList

            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "hola", 5,6.7,false,4,2,"saludos",3.5,3 });

            // obtenemos solo los enteros
            var enteros = lista.OfType<int>();

            foreach(int n in enteros)
                Console.WriteLine(n);

            Console.WriteLine("------");

            // creamos un ArrayList
            ArrayList estudiantes = new ArrayList()
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientado a objetos",9.0),
                new CEstudiante("Juan","S875","Programacion basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","S456", "Orientado a objetos",8.3)
            };

            // tenemos que transformar el ArrayList a un tipo que implemente a 
            // IEnumerable<T> para poder ser usando con LINQ
            var estl = estudiantes.OfType<CEstudiante>();

            // Ahora si usamos LINQ
            // Encontramos a los reprobados
            var reprobados = from e in estl
                             where e.Promedio <= 5.0
                             select e;
            // mostramos
            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r);

            // hacemos proyeccion a un nuevo tipo por medio de tipos anonimos

            // Creamos una lista
            List<CEstudiante> estudiantes2 = new List<CEstudiante>
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientado a objetos",9.0),
                new CEstudiante("Juan","S875","Programacion basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","S456", "Orientado a objetos",8.3)
            };

            var nombrePromedio = from e in estudiantes2
                                 select new { e.Nombre, e.Promedio };

            Console.WriteLine("Proyeccion");

            foreach (var np in nombrePromedio)
                Console.WriteLine(np.ToString());            
        }
    }
}
