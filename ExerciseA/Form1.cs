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
        List<int> numberList1 = Enumerable.Range(1, 10).ToList();
        List<int> numberList2 = Enumerable.Range(1, 10).ToList();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            List<int> multiList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                multiList.Add (numberList1[i] * numberList1[i]);
            }

             StringBuilder sb = new StringBuilder();
            foreach (int num in multiList)
            {
                sb.AppendLine(num.ToString());
            }
            MessageBox.Show(sb.ToString());


           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = numberList1;
            listBox2.DataSource = numberList2;

        }
    }
}
