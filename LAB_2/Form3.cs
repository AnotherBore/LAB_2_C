using System;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void TaskButton2_Click(object sender, EventArgs e)//выводим задание по нажатию кнопки
        {
            MessageBox.Show(@"Дано предложение.
Определить долю (в %) букв в нем.",
"Вариант 8",
MessageBoxButtons.OK,
MessageBoxIcon.Question);
        }

        private void Just_Text_Changed(object sender, EventArgs e)//если меняется значение в техтбоксе
        {
            string input = this.textInput.Text;
            string dol = " ";
            if (input.Length > 0)//если что-то введено
            {
               dol = Convert.ToString(LogicTask2.ProportionOfLetters(input));
            }
            TaskLabel.Text = dol;//выводим значение в лейбл

            Properties.Settings.Default.input = input;//сохраняем значение в параметры
            Properties.Settings.Default.Save();
        }
        public class LogicTask2
        {
            public static int ProportionOfLetters(string str)
            {
                UInt16 q = 0;//под подсчет количества букв
                UInt16 dol = 0;//для вычисления процентов
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLetter(str[i]))//определяем является ли буквой
                        q++;
                }
                dol = Convert.ToUInt16(q * 100 / str.Length);//считаем проценты
                return dol;//возвращаем проценты
            }
        }
    }
}
