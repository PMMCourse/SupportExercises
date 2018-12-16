using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(0, 450);
            int num2 = rnd.Next(0, 350);

            buttonRun.Location = new Point(num1,num2);
            

        }
        
    }
}
