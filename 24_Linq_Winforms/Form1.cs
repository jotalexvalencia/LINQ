using System.Linq;
using System.Windows.Forms;
// Necesario
using System.Xml.Linq;
namespace _24_Linq_Winforms
{
    public partial class Form1 : Form
    {
        // Nuestro documento XML
        XDocument documento = new XDocument();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            documento = XDocument.Load("Alumnos.xml");
            // Mostramos en el textbox
            txtXML.Text = documento.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo elemento
            XElement temp = new XElement("Alumno", new XAttribute("Nombre", txtNombre.Text),
                new XElement("Curso", txtCurso.Text),
                new XElement("Calificacion", txtCalificacion.Text)
                );
            // Lo adicionamos al documento
            documento.Descendants("Alumnos").First().Add(temp);

            // Actualizamos el tetbox
            txtXML.Text = documento.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var resultados = from a in documento.Descendants("Alumno")
                             where (string)a.Element("Curso") == txtBCurso.Text
                             select a.Element("Calificacion").Value + " " + a.Element("Curso").Value;

            // Construimos una cadena con la información
            string datos = "";
            foreach (var dato in resultados.Distinct())
            {
                datos += string.Format("Calificacion {0}\r\n", dato);
            }

            // Mostramos los resultados
            MessageBox.Show(datos);
        }
    }
}