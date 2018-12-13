using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseG
{
    public partial class Form1 : Form
    {
        List<int> numberList = new List<int>();
        public Form1()
        {
            InitializeComponent();
            numberList = Enumerable.Range(1, 10).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int num in numberList)
            {
                listBox1.Items.Add(num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);

        }
    }
}
