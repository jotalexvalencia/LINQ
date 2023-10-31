using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LinqFluentSintax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hemos estado utilizando una sintaxis que llamamos query expression
            ahora veremos una sintaxis que se conoce como fluent sintax
            Formalicemos algunso conceptos
            Sequence es un objeto que implementa a IEnumerable<T>
            Element es cada item en la secuencia
            Query operator es un metodo que transforma una secuencia
            Acepta una secuencia de entrada y dam como resultado una secuencia de salida
            Se tienen cera de 40 operadores para LINQ, estos forman parte de los standard query operators
            El query es una expresion que cuando se enumera transforma a la secuencia usando los operadores
            */

            // Creamos un arreglo sobre el cual trabajar
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            // Usamos expresion lambda como argumento, n es el argumento de entrada
            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);

            // mostramos los resultados
            foreach(int num in pares)
                Console.WriteLine(num);

            Console.WriteLine("------");

            // Creamos un arreglo sobfre el cual trabajar
            string[] postres = {"pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            IEnumerable<string> encontrados = postres.Where(p => p.Contains("manzana"));

            // Mostramos los resultados
            foreach(string postre in  encontrados)
                Console.WriteLine(postre);

            Console.WriteLine("------");

            //Encadenamos operadores
            //Se van adicionando operadores

            IEnumerable<string> manzanas = postres
                .Where(p => p.Contains("manzana"))
                .OrderBy(p => p.Length)
                .Select(p => p.ToUpper()); // El elemento es proyectado

            // Mostramos los resultados
            foreach (string postre in manzanas)
                Console.WriteLine(postre);

            Console.WriteLine("------");

        }
    }
}
