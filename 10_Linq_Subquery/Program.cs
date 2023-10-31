using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Linq_Subquery
{
    class Program
    {
        static void Main(string[] args)
        {
            // un subquery es un query que esta contenido en la expresion lambda de otro query
            // el scope que tiene existe dentro de la expresion que lo contiene

            // creamos un arreglos sobre el cual trabajar
            string[] postres = {"pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            // Ordenamos alfabeticamente de acuerdo a la ultima palabra de cada elemento
            // Split divide en una coleccion a la cadena
            // p.Split().Last() es el subquery

            IEnumerable<string> resultados = postres.OrderBy(p => p.Split().Last());            

            // Mostramos los resultados
            foreach (string postre in resultados) 
                Console.WriteLine(postre);

            Console.WriteLine("------");

            int[] numeros = { 19,14,56,32,11,8,45,7,18,2,17,23 };

            IEnumerable<int> nums = numeros
                .Where(n => n < numeros.First());

            // mostramos los resultados
            foreach (int n in nums)
                Console.WriteLine(n);

            Console.WriteLine("------");

            // numeros que sean menores o iguales al primer entero que se encuentre
            IEnumerable<int> nums2 = numeros
                .Where(n => n <= (numeros.Where(n2 => n2 % 2 == 0)).First());

            // Mostramos los resultados
            foreach (int n in nums2)
                Console.WriteLine(n);
            Console.WriteLine("------");
        }
    }
}
