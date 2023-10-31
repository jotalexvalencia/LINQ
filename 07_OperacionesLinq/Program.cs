using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OperacionesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // operaciones que podemos realizar con Linq
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

            // conteo
            int cantidad = (from e in estudiantes2
                            where e.Promedio>5
                            select e).Count();

            Console.WriteLine("La cantidad de aprobados es {0}", cantidad);
            Console.WriteLine("------");

            // Reversa

            var aprobados = from e in estudiantes2
                            where e.Promedio>5
                            select e;

            foreach(CEstudiante est in aprobados)
                Console.WriteLine(est);

            Console.WriteLine("Orden inverso");

            foreach(CEstudiante est in aprobados.Reverse())
                Console.WriteLine(est);

            // Ordenamiento

            Console.WriteLine("Ordenados");

            var ordenados = from e in estudiantes2
                            orderby e.Promedio descending
                            select e;

            foreach (CEstudiante est in ordenados)
                Console.WriteLine(est);

            Console.WriteLine("Ascendente");

            var ordenadosA = from e in estudiantes2
                             orderby e.Promedio ascending
                             select e;

            foreach(CEstudiante e in ordenadosA)
                Console.WriteLine(e);

            // Operaciones de agregacion

            int[] numeros = { 2, 5, 3, 9, 1, 6, 4, 7, 8 };

            Console.WriteLine("------");

            // encotramos el maximo
            int maximo = (from n in numeros select n).Max();
            Console.WriteLine("maximo {0}",maximo);

            // encontramos el minimo
            int minimo = (from n in numeros select n).Min();
            Console.WriteLine("minimo {0}", minimo);

            // encontramos el promedio
            double prom = (from n in numeros select n).Average();
            Console.WriteLine("el promedio es {0}",prom);

            // sumatoria
            int sumatoria = (from n in numeros select n).Sum();
            Console.WriteLine("la sumatoria es {0}", sumatoria);
        }
    }
}
