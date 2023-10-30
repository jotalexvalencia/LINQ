using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMetodoClase03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtener resultados de query desde metodos

            // Invocamos el metodo
            IEnumerable<int> resultados = CClaseExplicita.ObtenerNumerosPares();

            // Mostramos los resultados 
            foreach (int par in resultados)
                Console.WriteLine(par);

            Console.WriteLine("- - - - - -");

            IEnumerable<string> postres = CClaseExplicita.ObtenerPostres();

            // Mostramos los resultados
            foreach(string postre in postres)
                Console.WriteLine(postre);

            Console.WriteLine("- - - - - -");

            // Ejemplo de resultado de query inmediato
            int[] impares = CClaseExplicita.ObtenerNumerosImpares();

            // Mostramos los resultados
            foreach(int impar in impares)
                Console.WriteLine(impar);
        }
    }
}
