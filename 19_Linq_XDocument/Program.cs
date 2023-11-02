using System;
using System.Xml.Linq;

namespace _19_Linq_XDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            
            
            
            // Creamos un documento de XML mas completo
            XDocument documento = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"), // colocamos la declaracion del documento
                new XComment("Listado de alumnos"), // con eso colocamos un comentario
                new XProcessingInstruction("xml-stylesheet", "href='MyStyles.css' title='Compact' type='text/css'"),
                new XElement("{http://nicosio.com}Alumnos", // Lleva namespace {http://nicosio.com}
                    new XElement("Ana", new XAttribute("ID", "10100"),
                        new XElement("Curso", "Administracion"),
                        new XElement("Promedio", "10")
                        ), // fin de Ana
                    new XElement("Luis", new XAttribute("ID", "25350"),
                        new XElement("Curso", "Programacion"),
                        new XElement("Promedio", "9.5")
                        ) // fin de Luis
                    ) // fin de Alumnos

                ); // fin de Documento

            // Mostramos el documento
            Console.WriteLine(documento);

            // Guardamos en disco
            documento.Save("alumnos.xml");
        }
    }
}
