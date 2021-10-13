using System;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();           
        }

        private void TaskButton_Click(object sender, EventArgs e)//выводим задание при нажатии кнопки
        {
            MessageBox.Show(@"Дан прямоугольник с размерами a x b.
От него отрезают квадраты максимального размера, пока это возможно.
Затем от оставшегося прямоугольника вновь отрезают квадраты максимально возможного размера и т.д.
На какие квадраты и в каком их количестве будет разрезан исходный прямоугольник?",
"Вариант 16",
MessageBoxButtons.OK,
MessageBoxIcon.Question);
        }

        private void MainButton_Click(object sender, EventArgs e)//при нажатии кнопки
        {
            UInt16 sideA, sideB;//под две стороны прямоугольника
            //пробуем конвертировать строку в текстбоксах в число
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
                MessageBox.Show("Число за пределами ОДЗ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //проверяем стороны на корректность
            if (sideA == 0 || sideB == 0)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //сохраняем введенные данные
            Properties.Settings.Default.sideA = this.textA.Text;
            Properties.Settings.Default.sideB = this.textB.Text;
            Properties.Settings.Default.Save();

            UInt16 count = LogicTask1.CuttingSquares(sideA, sideB);// сохраняем количество квадратов
            //выводим меседжбоксс результатами
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.textA.Text = "";
            this.textB.Text = "";
        }
    }
    public class LogicTask1
    {
        public static string squares = "";//заводим переменную под историю разрезов
        public static UInt16 CuttingSquares(UInt16 a, UInt16 b)
        {
            squares = "";
            UInt16 count = 1; // для подсчета количества отсечений
            if (a == b) //если уже квадрат
            {
                return count;
            }
            while (a != b) // пока не разрезалось в последний раз
            {
                if (a < b) //проверяем какая сторона больше
                {
                    b -= a; //отсекаем по большей стороне
                    squares = squares + $"{count}. {a} x {a}" + "\n";//в строку вписываем кавадрат и переносим строку
                }
                else
                {
                    a -= b;
                    squares = squares + $"{count}. {b} x {b}" + "\n";
                }

                count++;
            }
            squares = squares + $"{count}. {a} x {a}" + "\n"; //выводим последний квадрат
            return count; //возвращаем количество отрезаний
        }
    }
}
