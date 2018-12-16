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

        private void Form1_Load(object sender, EventArgs e)
        {
                   
            Conductor conductor1 = new Conductor();
           
            comboBox1.DataSource = Enum.GetValues(typeof(Tipo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(textBoxNum.Text.Trim(), out num);

            int num2;
            bool isNum2 = int.TryParse(textBox9Letters.Text.Trim(), out num2);

            if (!isNum)
            {
                MessageBox.Show("no es un numero lo introducido en el textbox 1");
            }

            if(textBox9Letters.Text.Length>9 || isNum2)
            {
                MessageBox.Show("tiene mas de 9 letras o un numero el textbox 2");

            }

                
        }
    }
}
