using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*pictureBox1.Image=i*/
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.ImageLocation = ofd.FileName;


            }
            else {

                MessageBox.Show("Error al cargar la imagen");

            }
        }
    }
}
