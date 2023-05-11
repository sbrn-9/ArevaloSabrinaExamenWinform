using DotnetExam.Entities;

namespace DotnetExam.WinFormsApp
{

    /*Que se cree un solo formulario que posea estos controles (un textbox para búsqueda, 
     * el botón buscar y dos dataGridView, ademas se tiene 3 labels)
     * Los DataGridView son para las Materias y el otro para los alumnos de la materia seleccionada

     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarMaterias();
        }

        public void GenerarMaterias()
        {
            var materias = (new Materia()).Cargar(String.Empty);

                dataGridView1.DataSource = materias;

            }
        }
}
