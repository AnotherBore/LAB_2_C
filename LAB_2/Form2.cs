using System;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)//если нажали первую кнопку
        {
            Task1 task1 = new Task1();//открываем окно задачи на for
            task1.Show();
        }

        private void Task2Button_Click(object sender, EventArgs e)//если нажали вторую кнопку
        {
            Task2 task2 = new Task2();//открываем окно задачи на строки
            task2.Show();
        }
    }
}
