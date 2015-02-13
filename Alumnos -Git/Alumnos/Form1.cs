using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Alumnos alumn = new Alumnos();

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alu = new Alumno();
            string texto;
            double media;

            alu.Nombre = textBox1.Text;
            alu.Nota = (int)numericUpDown1.Value;
            textBox1.Text = "";



            if (alu.Aprobado == true)
                texto = "Aprobado";
            else
                texto = "Suspendido";

            alumn.AgregarAlumno(alu);

            

            ltb1.Items.Add(alu.Nombre + "       " + "Nota: " +  numericUpDown1.Value + "       " + texto + "\r\n");

            media = alumn.MediaNotas();

            textBox4.Text = media.ToString();
        }
    }
}
