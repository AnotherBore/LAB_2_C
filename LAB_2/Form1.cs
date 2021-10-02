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
    public partial class Task1 : Form
    {
        public Task1()
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
MessageBoxIcon.Question);
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            UInt16 sideA, sideB;
            try
            {
                sideA = UInt16.Parse(this.textA.Text);
                sideB = UInt16.Parse(this.textB.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sideA == 0 || sideB == 0)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UInt16 count = LogicTask1.CuttingSquares(sideA, sideB);
            if (count > 1)
            {
                MessageBox.Show($"{LogicTask1.squares}\nКоличество квадратов - {count}", "Прямоугольник обработан");
            }
            else
            {
                MessageBox.Show("Это квадрат", "Прямоугольник обработан");
            }
        }

        private void Just_Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
    public class LogicTask1
    {
        public static string squares = "";
        public static UInt16 CuttingSquares(UInt16 a, UInt16 b)
        {
            squares = "";
            UInt16 count = 1;
            if (a == b)
            {
                return count;
            }
            while (a != b)
            {
                if (a < b)
                {
                    b -= a;
                    squares = squares + $"{count}. {a} x {a}" + "\n";
                }
                else
                {
                    a -= b;
                    squares = squares + $"{count}. {b} x {b}" + "\n";
                }

                count++;
            }
            squares = squares + $"{count}. {a} x {a}" + "\n";
            return count;
        }
    }
}
