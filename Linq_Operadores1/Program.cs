using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Operadores1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hay tres categorias para los operadores de query
            // Secuencia a secuencia (secuencia de entrada, secuencia de salida)
            // Secuencia de entrada, elemento sencillo o escalar
            // Nada de entrada, secuencia de salida

            // Secuencia a secuencia
            // Filtro: Where, Take, TakeWhile, Skip, SkipWhile, Distinct
            // Proyeccion: Select, SelectMany
            // Union: Join, GroupJoin, Zip
            // Ordenamiento: OrderBy, ThenBy, Reverse
            // Agrupamiento: GroupBy
            // Operadores de conjuntos: Concat, Union, Intersect, Except
            // Conversion import: OfType, Cast
            // Conversion export: ToArray, ToDictionary, ToLookup, AsEnumerable, AsQueryable

            // Secuencia a elemento o escalar
            // Operadores de elemento: First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, ElementAt, ElementeAtOrDefault, DefaultEmpty
            // Agregacion: Aggregate, Average, Count, LongCount, Sum, Max, Min
            // Cuantificador: All, Any, Contains, SequenceEqual

            // Nada de entrada, secuencia de salida
            // Generacion: Empty, Range, Repeat

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Filtro

            //Where regresa un subconjunto de elementos que satisfacen una condición
            //Take regresa el primer elemento n e ignora el resto
            //Skip ignora los primero n elementos y regresa el resto
            //TakeWhile emite elementos de la secuencia de entrada hasta que el predicado es falso
            //Skipwhile Ignora los elementos de la secuencia de entrada hasta que el predicado es falso, luego emite el resto
            //Distinct Regresa una secuencia que excluye a los duplicados

            // Where
            // Aparte de lo que hemos visto, where permite un segundo argumento de tipo int que simboliza el indice del elemento
            // Esto se conoce como filtrado por indice

            string[] postres = {"pay de manzana","pastel de chocolate","manzana caramelizada","fresas con crema","pay de pera y manzana" };
            Console.WriteLine("--- Where ---\r\n");
            IEnumerable<string> r1 = postres.Where((n, i) => i % 2 == 0);
            // Mostramos los resultados
            foreach (string postre in r1)
                Console.WriteLine(postre);
            Console.WriteLine("------");
            IEnumerable<string> r2 = from p in postres
                                     where p.StartsWith("pay")
                                     select p;
            // Mostramos los resultados
            foreach (string postre in r2)
                Console.WriteLine(postre);
            Console.WriteLine("------");
        }
    }
}
