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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            textInput.Text = Properties.Settings.Default.input;
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Дано предложение.
Определить долю (в %) букв в нем.",
"Вариант 8",
MessageBoxButtons.OK,
MessageBoxIcon.Question);
        }

        private void Just_Text_Changed(object sender, EventArgs e)
        {
            string input = this.textInput.Text;
            string dol = " ";
            if (input.Length > 0)
            {
               dol = Convert.ToString(LogicTask2.ProportionOfLetters(input));
            }
            TaskLabel.Text = dol;

            Properties.Settings.Default.input = input;
            Properties.Settings.Default.Save();
        }
        public class LogicTask2
        {
            public static int ProportionOfLetters(string str)
            {
                UInt16 q = 0;
                UInt16 dol = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetter(str[i]))
                        q++;
                }
                dol = Convert.ToUInt16(q * 100 / str.Length);
                return dol;
            }
        }
    }
}
