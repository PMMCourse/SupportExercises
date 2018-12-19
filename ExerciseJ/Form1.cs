using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Persona> ListaPersonas = new List<Persona>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Persona {

            public String dni { get; set; }
            public String nombre { get; set; }
            public String apellido { get; set; }
            public int edad { get; set; }

            public Persona(string dni, string nombre, string apellido, int edad)
            {
                this.dni = dni ?? throw new ArgumentNullException(nameof(dni));
                this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
                this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
                this.edad = edad;
            }
            public String getDni()
            {
                return this.dni;
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtDni.Text, txtnombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text));
            bool b = false;
            foreach (Persona p in ListaPersonas) {
                if (txtDni.Text==p.getDni())
                {
                    MessageBox.Show("la persona ya existe");
                    b = true;
                }
              

            }
            if (!b)
                ListaPersonas.Add(persona);



            txtDni.Text = "";
            txtnombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";

          
        }
    }
}
