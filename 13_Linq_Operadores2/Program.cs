using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Linq_Operadores2
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

            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema", "pay de pera y manzana" };
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
            IEnumerable<string> r3 = from p in postres
                                     where p.EndsWith("manzana")
                                     select p;
            // Mostramos los resultados
            foreach (string postre in r3)
                Console.WriteLine(postre);
            Console.WriteLine("------");
            Console.WriteLine("--- TakeWhile ---\r\n");
            //TakeWhile enumera la secuencia de entrada y emite cada elemento hasta que el predicado es falso
            // ignora el resto
            // creamos un arreglo sobre el cual trabajar
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };
            var r4 = numeros.TakeWhile(n => n < 8);
            // Mostramos los resultados
            foreach (int n in r4)
                Console.WriteLine(n);
            Console.WriteLine("------");
            Console.WriteLine("--- SkipWhile ---\r\n");
            // SkipWhile enumera la secuencia ignora los elementos hasta que el predicado es falso y emite el resto
            var r5 = numeros.SkipWhile(n => n < 8);
            // Mostramos los resultados
            foreach (int n in r5)
                Console.WriteLine(n);
            Console.WriteLine("------");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            // Proyeccion
            // Select transforma el elemento de entrada con la expresion lambda
            // SelectMany transforma el elemento lo aplana y concatena con los subsecuencias resultantes
            // Hemos usado Select con tipos anonimos o para tomar el elemento completamente
            // Proyeccion indexada
            Console.WriteLine("--- Proyeccion indexada ---\r\n");
            IEnumerable<string> r6 = postres.Select((p, i) => "Indice " + i + " para el postre " + p);
            // Mostramos los resultados
            foreach (string n in r6)
                Console.WriteLine(n);
            Console.WriteLine("------");
            // SelectMany
            // En Select cada elemento de entrada produce un elemento de salida
            // SelectMany produce 0..n elementos.
            Console.WriteLine("--- SelectMany ---\r\n");
            IEnumerable<string> r7 = postres.SelectMany(p => p.Split());
            // Mostramos los resultados
            foreach (string n in r7)
                Console.WriteLine(n);
            Console.WriteLine("------");
            // Comparamos con Select
            Console.WriteLine("Comparamos con Select");
            // Regresa un arreglo de cadenas no esta aplanado
            IEnumerable<string[]> r8 = postres.Select(p => p.Split());
            foreach (string[] n in r8)
            { 
                Console.WriteLine("-"); 
                foreach (string m in n) 
                    Console.WriteLine(m);
            }
            Console.WriteLine("------");
            // Select con multiples variables de rango
            Console.WriteLine("--- Select con multiples variables ---\r\n");
        }
    }
}
