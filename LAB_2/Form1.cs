using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Дан прямоугольник с размерами a x b.
От него отрезают квадраты максимального размера, пока это возможно.
Затем от оставшегося прямоугольника вновь отрезают квадраты максимально возможного размера и т.д.
На какие квадраты и в каком их количестве будет разрезан исходный прямоугольник?",
"Вариант 16",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
        }

        private void MainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
