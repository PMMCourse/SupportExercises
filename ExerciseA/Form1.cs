using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++) {

                listBox1.Items.Add(i);
                listBox2.Items.Add(i);

            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(listBox1.SelectedItem);
            int num2 = Convert.ToInt32(listBox2.SelectedItem);

            MessageBox.Show("El Resultado es: "+(num1*num2));
        }
    }
}
