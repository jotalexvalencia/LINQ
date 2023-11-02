using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Necesario
using System.Xml.Linq;

namespace _18_Linq_ParaXML
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                XML  es muy utilizado, pero es tedioso trabajar con el, qunque sencillo
                El framework provee System.Xml.dll y XmlReader, XmlWriter
                Pero es mas sencillo trabajr con LINQ para XML

                Cada parte de XML: declaracion, elemento, atributos. Pueden representarse por clases
                Si esas clases tiene colecciones, entonces podemos representar un arbol que
                describe al documento XML, esa es la base de DOM (Document Object Model)

                LINQ para XML tiene un DOM conocido como X-DOM y operadores extra
                XObject - Clase abstracta que es la base para todo el contenido de XML
                XNode - Clase base para la mayoria del contenido XML, excepto atributos
                XContainer - Define miembros para trabajar con sus hijos y es la clase padre de XElement y XDocument
                XElement - Define a un elemento
                XDocument - Representa la raiz de un arbol XML, en realidad envuelve a un XElement que actua como raiz
                            y lo podemos usar para adicion la declaracion e instrucciones de procesamiento.
                            Se puede usar X-DOM sin tener un XDocument
             */

            // Creamos un documento sencillo de XML con LiNQ
            XElement raiz = new XElement("raiz");
            XElement el1 = new XElement("Elemento1");
            el1.Add(new XAttribute("atributo", "valor"));
            el1.Add(new XElement("Anidado", "Contenido"));

            raiz.Add(el1);
            Console.WriteLine(raiz);
            Console.WriteLine("-------------------");

            // Esta forma de crear el documento se conoce como construccion funcional
            XElement documento = new XElement("Alumnos",
                new XElement("Ana", new XAttribute("ID", "10100"),
                    new XElement("Curso", "Administracion"),
                    new XElement("Promedio", "10")
                    ),// fin de ana
                new XElement("Luis", new XAttribute("ID", "25350"),
                    new XElement("Curso", "Programacion"),
                    new XElement("Promedio", "9.5")
                    )// fin de luis
                );// fin de alumnos

            // imprimimos el documento
            Console.WriteLine(documento);

            // escribimos el documento a disco
            documento.Save("Alumnos.xml");
        }
    }
}
