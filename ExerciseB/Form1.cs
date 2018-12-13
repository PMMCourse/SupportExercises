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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(textBoxNumber.Text, out n);

            if (isNumeric)
            {
                listBoxNumbers.Items.Add(n);
            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int max = (int)listBoxNumbers.Items[0];
            int min = (int)listBoxNumbers.Items[0];
           
           
            for (int i = 0; i<listBoxNumbers.Items.Count ; i++)
            {
                if ((int)listBoxNumbers.Items[i] > max)
                {
                    max = (int)listBoxNumbers.Items[i];
                }

                if ((int)listBoxNumbers.Items[i] < min)
                {
                    min = (int)listBoxNumbers.Items[i];
                }

            }


            MessageBox.Show($"el maximo es {max} y el minimo {min}");
        }
    }
}
