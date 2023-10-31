using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OperacionesLinq
{
    class CEstudiante
    {
        private string nombre;
        private string id;
        private string curso;
        private double promedio;

        public string Nombre { get => nombre; }
        public string Id { get => id; }
        public string Curso { get => curso; }
        public double Promedio { get => promedio; }

        public CEstudiante(string pNombre, string pId, string pCurso, double pPromedio)
        => (nombre, id, curso, promedio) = (pNombre, pId, pCurso, pPromedio);

        public override string ToString()
        {
            return string.Format("Nombre: {0}, {1}, curso: {2}, promedio: {3}", nombre, id, curso, promedio);
        }
    }
}
