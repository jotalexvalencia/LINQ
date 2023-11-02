namespace _17_Linq_Operadores6
{
    class CEstudiante
    {
        private string nombre;
        private int id;

        public CEstudiante(string pNombre, int pId) => (nombre, id) = (pNombre, pId);

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("Estudiante {0}, {1}", nombre, id);
        }

    }

    class CCurso
    {
        private string curso;
        private int id;

        public CCurso(string pCurso, int pID) => (curso, id) = (pCurso, pID);

        public string Curso { get => curso; set => curso = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("Curso =>{0}", curso);
        }

    }
}
