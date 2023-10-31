using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            // Except nos da la diferencia entre 2 contenedores
            var expt = (from n1 in conjunto1 select n1)
                .Except(from n2 in conjunto2 select n2);

            Console.WriteLine("Except");
            foreach (int num in expt)
                Console.WriteLine(num);

            // Intersect nos da lo comun entre los dos contenedores

            var ints = (from n1 in conjunto1 select n1)
                .Intersect(from n2 in conjunto2 select n2);

            Console.WriteLine("Intersect");
            foreach (int num in ints)
                Console.WriteLine(num);

            // Union nos da la union de los dos contenedores sin repeticiones

            var un = (from n1 in conjunto1 select n1)
                .Union(from n2 in conjunto2 select n2);

            Console.WriteLine("Union");
            foreach (int n in un)
                Console.WriteLine(n);

            // Concat, concatena directamente los contenedores

            var cnt = (from n1 in conjunto1 select n1)
                .Concat(from n2 in conjunto2 select n2);

            Console.WriteLine("Concat");
            foreach (int num in cnt)
                Console.WriteLine(num);

            // Distinct, remueve los dpuplicados

            Console.WriteLine("Distinct");
            foreach(int num in cnt.Distinct())
                Console.WriteLine(num);

        }
    }
}
