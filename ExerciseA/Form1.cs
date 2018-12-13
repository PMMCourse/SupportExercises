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
                list1.Items.Add(i);
                list2.Items.Add(i);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int numero1 = Convert.ToInt32(list1.SelectedItem);
           int numero2 = Convert.ToInt32(list2.SelectedItem);
            int reultado = numero1 * numero2;

            MessageBox.Show("La multiplicacion es: " +reultado);
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
