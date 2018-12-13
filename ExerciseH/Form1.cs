using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum vehiculos
        {

            vehiculo = 1, camion, moto, coche

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vehiculos vehiculos;
            for (int i = 0; i < 5; i++)
            {
                comboBox1.Items.Add(vehiculos = (vehiculos)i);
            }
            txt_nume.MaxLength = 1;
            txt_text.MaxLength = 9;
        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public class conductor
        {
            public int id { get; set; }
            public String nombre { get; set; }
            public enum vehiculos
            {

                vehiculo = 1, camion, moto, coche

            }


        }

        private void txt_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }

}