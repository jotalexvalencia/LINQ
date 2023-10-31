using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LinqMasOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ordenamientos y otros operadores

            // creamos un arreglo sobre el cual trabajar
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            IEnumerable<int> desdeInicio = numeros.Take(5);

            // mostramos los resultados
            foreach (int i in desdeInicio)
                Console.WriteLine(i);

            Console.WriteLine("------");

            IEnumerable<int> brinco = numeros.Skip(5);

            // mostramos los resultados
            foreach(int i in brinco)
                Console.WriteLine(i);

            Console.WriteLine("------");

            IEnumerable<int> reversa = numeros.Reverse();

            // mostramos los resultados
            foreach (var item in reversa)
                Console.WriteLine(item);

            Console.WriteLine("------");

            // Encontramos primero
            Console.WriteLine("El primero es {0}", numeros.First());

            // Encontramos el ultimo
            Console.WriteLine("El ultimo es {0}", numeros.Last());

            // Encontramos el elemento en el indice 3
            Console.WriteLine("En el indice 3 esta {0}", numeros.ElementAt(3));

            // Vemos si contiene a determinado elemento
            Console.WriteLine("Contiene al 15 - {0}", numeros.Contains(15));

            // Vemos si hay elementos
            Console.WriteLine("Tiene elementos - {0}", numeros.Any());

            // vemos is hay multiplos de 5
            Console.WriteLine("Hay multiplos de 5 - {0}", numeros.Any(n => n % 5 == 0));
            Console.WriteLine("------");

            // Cuidado con los cambios de valor entre la ejecucion de los query

            int valor = 2;
            IEnumerable<int> resultados = numeros.Where(n => n % valor == 0);

            valor = 3;

            foreach (var item in resultados)
                Console.WriteLine(item);
        }
    }
}
