using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQINTRODUCCION01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Language Integrated Query
            // Se introdujo en .NET 3.5
            // Es una forma concisa, simétrica y fuertemente tipificada de acceder a datos

            // Requisitos
            // C#, POO
            // Tipos ímplicitos, colecciones, expresiones lambda, métodos de extensión, tipos anónimos

            // Se crean expresiones de query, recuerdan SQL, pero no es SQL
            // La expresión puede interactuar con múltiples tipos de datos, no solo con base de datos

            // LINQ to Objects-> se usa para arreglos y colecciones
            // LINQ to XML-> para manipular y hacer queries a documentos XML
            // LINQ to Dataset-> se usa con objetos Dataset de ADO.NET
            // LINQ to Entities-> para el procesamiento en paralelo de los datos que regresa un query

            // Las expresiones de LINQ son fuertemente tipificadas

            // Queries sencillos con arreglos y reflexión

            // Ejemplo con números
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };

            // Hacemos el query
            IEnumerable<int> valores = from n in numeros
                                       where n >3 && n < 8
                                       select n;

            // Mostramos los resultados
            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("- - - - - -");

            // Ejemplo con cadenas
            string[] postres = {"pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            // Hacemos un query
            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p 
                                              select p;

            // Mostramos los resultados
            foreach (string postre in encontrados)
                Console.WriteLine(postre);

            Console.WriteLine("- - - - - -");

            // Hacemos reflexión
            InformacionResultados(valores);
            Console.WriteLine("- - - - - -");
            InformacionResultados(encontrados);
        }

        static void InformacionResultados(object pResultados)
        {
            Console.WriteLine("Tipo {0}", pResultados.GetType().Name);
            Console.WriteLine("Location {0}", pResultados.GetType().Assembly.GetName().Name);
        }
    }
}
