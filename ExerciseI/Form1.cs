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

        private void bt1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(397, 440);
            bt1.Location = new Point(randomNumber);
        }
    }
}
