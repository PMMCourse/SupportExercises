using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseB
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

        private void bt1_Click(object sender, EventArgs e)
        {
            list1.Items.Add(txt_numero.Text);
            txt_numero.Text = "";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int maximo = list1.Items.Cast<string>().Max(x => Convert.ToInt32(x));
            int minimo = list1.Items.Cast<string>().Min(x => Convert.ToInt32(x));

            MessageBox.Show("El numero mayor es: "+maximo+" El numero menor es: "+minimo); 
        }
    }
}
