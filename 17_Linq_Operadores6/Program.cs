using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_Linq_Operadores6
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
            IEnumerable<string> r9 = from p in postres
                                     from p1 in p.Split()
                                     select p1 + " ===> " + p;
            // Mostramos los resultados
            foreach (string n in r9)
                Console.WriteLine(n);
            Console.WriteLine("------");
            IEnumerable<string> r10 = from p in postres
                                      from p1 in postres
                                      select "Yo quiero:" + p1 + " y tu quieres: " + p;

            // Mostramos los resultados
            foreach (string n in r10)
                Console.WriteLine(n);
            Console.WriteLine("------");

            // Union - Joining
            // Join une los elementos de dos colecciones en un solo conjunto
            // GroupJoin es como Join pero da un resultado jerarquico
            // Zip Enumera dos secuencias y aplica una funcion a cada par

            Console.WriteLine("--- Join ---\r\n");

            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", 100),
                new CEstudiante("Mario", 150),
                new CEstudiante("Susana", 180)
            };

            List<CCurso> cursos = new List<CCurso>
            {
                new CCurso("Programacion",100),
                new CCurso("Orientado objetos",150),
                new CCurso("Programacion",150),
                new CCurso("Programacion",180),
                new CCurso("UML",100),
                new CCurso("Orientado objetos",100),
                new CCurso("UML",180),
            };

            var listado = from e in estudiantes
                          join c in cursos on e.Id equals c.Id
                          select e.Nombre + " esta en el curso " + c.Curso;

            // Mostramos los resultados
            foreach (string n in listado)
                Console.WriteLine(n);

            Console.WriteLine("--- GroupJoin ---\r\n");
            // GroupJoin
            // Los resultados se obtienen en forma jerarquica
            // la sintaxis es la misa de Join pero utilizamos into

            var listado2 = from e in estudiantes
                           join c in cursos on e.Id equals c.Id
                           into tempListado
                           select new { estudiante = e.Nombre, tempListado };

            // Mostramos los resultados
            foreach (var lst in listado2)
            {
                Console.WriteLine(lst.estudiante);

                foreach (var lst2 in lst.tempListado)
                {
                    Console.WriteLine(lst2);
                }
            }

            // ZIP
            // Regresa una secuencia que aplica una funcion a cada par

            Console.WriteLine("--- ZIP ---\r\n");

            string[] helados = { "chocolate", "vainilla", "fresa", "limon" };

            IEnumerable<string> r12 = postres.Zip(helados, (p, h) => p + " con helado de " + h);

            foreach (string n in r12)
                Console.WriteLine(n);

            // Ordenamiento
            // OrderBy, ThenBy Ordena en orden ascendente
            // OrderByDescending, ThenByDescending Ordena en orden descendente
            // Reverse regresa en el orden inverso

            IEnumerable<int> numOrder = numeros.OrderBy(n => n);
            IEnumerable<int> numDes = numeros.OrderByDescending(n => n);

            Console.WriteLine("--- OrderBy ---");
            foreach (int n in numOrder)
                Console.WriteLine(n);
            Console.WriteLine("--- OrderByDescending ---");
            foreach (int n in numDes)
                Console.WriteLine(n);

            Console.WriteLine("------");
            string[] palabras = { "hola", "piedra", "pato", "pastel", "carros", "auto" };
            IEnumerable<string> palabrasOrd = palabras.OrderBy(p => p.Length).ThenBy(p => p);
            foreach (string n in palabrasOrd)
                Console.WriteLine(n);

            // Agrupamiento
            // GroupBy Agrupa una secuencia en subsecuencias
            Console.WriteLine("--- Agrupamiento ---\r\n");
            string[] archivos = System.IO.Directory.GetFiles("D:\\PERSONAL"); //D:\PERSONAL
            Console.WriteLine("Archivos obtenidos por GetFiles");
            foreach (string n in archivos)
                Console.WriteLine(n);

            // Agrupamos basados en la etension
            // Adentro de  () colocamos el criterio de agrupamiento
            var archivoAg = archivos.GroupBy(a => System.IO.Path.GetExtension(a));
            Console.WriteLine("Resultados agrupados");
            foreach (IGrouping<string, string> g in archivoAg) //IGrouping llave, agrupamiento
            {
                Console.WriteLine("Archivos de extension {0}", g.Key); // Aqui usamos la llave de agrupamiento
                foreach (string a in g)
                    Console.WriteLine("\t {0}", a);
            }

            // Conjuntos
            // Concat, Uniion, Intersect, Except

            // Conversion
            // OfType Convierte de IEnumerable a IEnumerable<T>, desecha los elementos erroneos
            // Cast Convierte de IEnumerable a IEnumerable<T>, lanza excepcion con los elementos erroneos
            // ToArray Convierte de IEnumerable< T > a T[]
            // ToList Convierte de IEnumerable<T> a List<T>
            // ToDictionary convierte de IEnumerable<T> a Dictionary<TKey, TValue>
            // ToLookUp Convierte de IEnumerable<T> a ILookUp<TKey, TElement>
            // AsEnumerable Hace downcast a IEnuemrable<T>
            // AsQueryable Hace cast o convierte a IQueryable<T>

            // De elemento
            // First, FirstOrDefault Regresa primer elemento de la secuencia
            // Last, LastOrDefault Regresa el ultimo elemento de la secuencia
            // Single, SingleOrDefault Equivalente a First, FirsOrDefault pero lanza una excepion si hay mas de uno
            // ElementAt, ElementAtOrDefault Regresa el elemento de determinada posicion
            // DefaultIfEmpty Regresa al elemento de default si la secuencia no tiene elementos

            Console.WriteLine("--- De elemento ---\r\n");
            // Obtenemos el primero
            int primero = numeros.First();
            Console.WriteLine(primero);

            // Primero que cumpla cierta condicion
            int primeroc = numeros.First(n => n % 2 == 0);
            Console.WriteLine(primeroc);

            // Primero que cumpla o default
            int primerod = numeros.FirstOrDefault(n => n % 57 == 0);
            Console.WriteLine(primerod);

            //Agregacion
            //Count, LongCount Regresa la cantida de elementos en la secuencia int o int64
            //Min Regresa el elemento menor de la secuencia
            //Max Regresa el elemento mayor de la secuencia
            //Sum Regresa la sumatoria de los elementos
            // Average Regresa el promedio de los elementos
            // Aggregate Hace una agregacion usando nuestro algoritmo

            Console.WriteLine("--- De agregacion ---\r\n");
            int sumatoria = numeros.Sum();
            Console.WriteLine(sumatoria);

            int[] numeros2 = { 1, 2, 3, 4, 5 };
            // En este caso la semilla es cero si no se pone la semilla, toma el primer valor
            int agregado = numeros2.Aggregate(0, (t, n) => t + (n * 2));
            Console.WriteLine(agregado);

            /*
             * t es acumulador, n es cada elemento de numeros1
             * 0 +(1*2) = 2
             * 2 +(2*2) = 6
             * 6 +(3*2) = 12
             * 12 +(4*2) = 20
             * 20 +(5*2) = 30
             */

            // Cuantificadores
            // Contains Regresa true si la secuencia contiene al elemento
            // Any Regresa true si un elemento satisface al predicado
            // All Regresa true si todos los elementos satisfacen al predicado
            // SequenceEqual Regresa true si la segunda secuencia tiene elementos identicos a la de entrada

            Console.WriteLine("--- Cuantificadores ---\r\n");

            bool todos = numeros2.All(n => n < 10);
            Console.WriteLine(todos);

            bool iguales = numeros2.SequenceEqual(numeros);
            Console.WriteLine(iguales);

            // Generacion
            // Empty crea una secuencia vacia
            // Repeat crea una secuencia de elementos que se repiten
            // Range crea una secuencia de enteros

            Console.WriteLine("--- Generacion ---\r\n");
            var vacia = Enumerable.Empty<int>();
            foreach (int n in vacia)
                Console.WriteLine(n);
            Console.WriteLine("------");
            var repetir = Enumerable.Repeat("hola", 5);
            foreach (string n in repetir)
                Console.WriteLine(n);
            var rango = Enumerable.Range(5, 15); // inicio, elementos
            foreach (int n in rango)
                Console.WriteLine(n);
        }
    }
}
