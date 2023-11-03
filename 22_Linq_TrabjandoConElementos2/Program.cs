using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace _22_Linq_TrabjandoConElementos2
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new XElement("Escuela",
                                    new XElement("Ciencias",
                                        new XElement("Materia", "Matematicas"),
                                        new XElement("Materia", "Fisica")
                                        ),
                                    new XElement("Artes",
                                        new XElement("Materia", "Historia del arte"),
                                        new XElement("Practica", "Pintura")
                                        )
                                );

            Console.WriteLine(escuela);
            Console.WriteLine("----------------------------------------------------");
            // Nodes regresa a los hijos
            foreach (XNode nodo in escuela.Nodes())
                Console.WriteLine(nodo.ToString());
            Console.WriteLine("----------------------------------------------------");
            // Elements regresa los hijos de los nodos de tipo XElement
            foreach (XElement elemento in escuela.Elements())
                Console.WriteLine(elemento.Name + "=" + elemento.Value);
            //Console.WriteLine(elemento);//.Name + "=" + elemento.Value);
            Console.WriteLine("----------------------------------------------------");
            // FirstNode nos regresa el primer nodo
            Console.WriteLine(escuela.FirstNode);
            // Encontramos el padre del primer nodo
            Console.WriteLine(escuela.FirstNode.Parent.Name);
            Console.WriteLine("----------------------------------------------------");
            // LastNode nos regresa el ultimo nodo
            Console.WriteLine(escuela.LastNode);
            Console.WriteLine("----------------------------------------------------");
            // Obtiene todos los elementos donde se encuentre fisica
            IEnumerable<string> materias = from curso in escuela.Elements()
                                           where curso.Elements().Any(materia => materia.Value == "Fisica")
                                           select curso.Value;
            foreach (string s in materias)
                Console.WriteLine(s);
            Console.WriteLine("----------------------------------------------------");

            // Obtiene el nombre de elemento padre de fisica
            IEnumerable<XName> tipoCurso = from curso in escuela.Elements()
                                           where curso.Elements().Any(materia => materia.Value == "Fisica")
                                           select curso.Name;
            foreach (XName s in tipoCurso)
                Console.WriteLine(s.ToString());
            Console.WriteLine("----------------------------------------------------");
            // Solamente selecciona los nodos materia
            IEnumerable<string> materias2 = from curso in escuela.Elements()
                                            from asignatura in curso.Elements()
                                            where asignatura.Name == "Materia"
                                            select asignatura.Value;
            foreach (string m in materias2)
                Console.WriteLine(m);
            Console.WriteLine("----------------------------------------------------");
            // Contamos los elementos de un tipo particular
            int n = escuela.Elements("Ciencias").Count();
            Console.WriteLine("Hay {0} Ciencias", n);
            Console.WriteLine("----------------------------------------------------");
            // Element nos da la primera ocurrencia de un elemento con ese nombre
            string mat = escuela.Element("Ciencias").Element("Materia").Value;
            Console.WriteLine(mat);
            Console.WriteLine("----------------------------------------------------");
            // Obtenemos el siguiente nodo estilo lista ligada
            XNode s2 = escuela.FirstNode;
            Console.WriteLine(s2);
            Console.WriteLine("--- Tomanos el siguiente ---");
            s2 = s2.NextNode;
            Console.WriteLine(s2);
            Console.WriteLine("----------------------------------------------------");
            // Otra forma de crear un elemento, el parent es escuela
            escuela.SetElementValue("Deportes", "No hay");
        }
    }
}
