using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        List<Alumno>alumnos= new List<Alumno>();
        List<Taller>talleres= new List<Taller>();
        List<Inscripcion>inscripciones= new List<Inscripcion>();
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarAlumnos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos;
            dataGridView1.Refresh();
        }

        public void MostrarTaller()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = talleres;
            dataGridView2.Refresh();
        }

        public void MostrarInscripcion()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = talleres;
            dataGridView2.Refresh();
        }

        public void cargarEstudiante()
        {
            string fileName = "Alumnos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            alumnos.Clear();
            comboBoxEstudiante.Items.Clear();

            while (reader.Peek() > -1)
            {
                Alumno alumno = new Alumno();
                alumno.Nombre = reader.ReadLine();
                alumno.Dpi = reader.ReadLine();
                alumno.Direccion = reader.ReadLine();
                alumnos.Add(alumno);
                comboBoxEstudiante.Items.Add(alumno.Dpi);
            }
            reader.Close();
            MostrarAlumnos(); 
        }

        public void cargarInscripcion()
        {
            string fileName = "Inscripciones.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            alumnos.Clear();
            

            while (reader.Peek() > -1)
            {
                Inscripcion inscripcion = new Inscripcion();
                inscripcion.DpiEstudiante = reader.ReadLine();
                inscripcion.IdTaller = reader.ReadLine();
                inscripcion.Fecha = Convert.ToDateTime(reader.ReadLine());
                inscripciones.Add(inscripcion);
      
            }
            reader.Close();
            MostrarInscripcion();
        }

        public void cargarTaller()
        {
            string fileName = "Talleres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            talleres.Clear();
            comboBoxTaller.Items.Clear();

            while (reader.Peek() > -1)
            {
                Taller taller = new Taller();
                taller.CodigoTaller = reader.ReadLine();
                taller.NombreTaller = reader.ReadLine();
                taller.Costo = Convert.ToInt16(reader.ReadLine());
                talleres.Add(taller);
                comboBoxTaller.Items.Add(taller.NombreTaller);
            }
            reader.Close();
            MostrarTaller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarEstudiante();
            cargarTaller();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.DpiEstudiante = comboBoxEstudiante.Text;
            inscripcion.IdTaller = comboBoxTaller.Text;
            inscripcion.Fecha = DateTime.Now;

            inscripciones.Add(inscripcion);

            string fileName = "Inscripciones.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var inscripcion1 in inscripciones)
            {
                writer.WriteLine(inscripcion1.DpiEstudiante);
                writer.WriteLine(inscripcion1.IdTaller);
                writer.WriteLine(inscripcion1.Fecha);
            }
            writer.Close();

            //limpiar();
            MessageBox.Show("Temperatura registrada");
            cargarInscripcion();
        }
    }
}
