using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        int number = 0; //загаданое число
        int count = 0; //количество ходов
        int minCount = 0; //минимальное кол-во ходов
        int currentNumber = 0; //текущее число
        Stack<int> values = new Stack<int>(); //стек чисел
        public Form1()
        {
            //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю. +
            //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
            //Игрок должен получить это число за минимальное количество ходов.
            //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
            //Вся логика игры должна быть реализована в классе с удвоителем.

            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnCancel.Text = "Отмена";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCommandCount.Text = "Количество ваших ходов: 0";
            lblMinCommandCount.Text = "Минимальное количество ховов: 0";
            panel1.Enabled = false;
            this.Text = "Удвоитель";
        }

        /// <summary>
        /// Кнопка +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            values.Push(currentNumber);
            currentNumber++;
            lblNumber.Text = currentNumber.ToString();
            lblCommandCount.Text = $"Количество ваших ходов: {++count}";
            CheckWin();
        }

        /// <summary>
        /// Кнопка *2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            values.Push(currentNumber);
            currentNumber *= 2;
            lblNumber.Text = currentNumber.ToString();
            lblCommandCount.Text = $"Количество ваших ходов: {++count}";
            CheckWin();
        }

        /// <summary>
        /// Кнопка Сброс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Restart();
        }

        /// <summary>
        /// Меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            number = random.Next(1, 101);
            MessageBox.Show($"Необходимо получить {number}");
            minCount = MinCountMove();
            lblMinCommandCount.Text = $"Минимальное количество ховов: {minCount}";
            lblChange.Text = $"0 -> {number}";
            panel1.Enabled = true;
            Restart();
        }

        /// <summary>
        /// Определение минимального количества ходов
        /// </summary>
        /// <returns>Минимально количество ходов</returns>
        private int MinCountMove()
        {
            int min = 1;
            int temp = number;
            while (temp != 1)
            {
                if(temp % 2 == 1)
                {
                    temp--;
                    min++;
                }
                else
                {
                    temp /= 2;
                    min++;
                }
            }
            return min;
        }

        /// <summary>
        /// Проверка окончания игры
        /// </summary>
        private void CheckWin()
        {
            if(int.Parse(lblNumber.Text) == number)
            {
                if(count == minCount)
                {
                    MessageBox.Show("Супер!");
                    Restart();
                    panel1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Попробуйте решить меньшим количеством ходов");
                }
            }
            if(int.Parse(lblNumber.Text) > number)
            {
                MessageBox.Show("Необходимое число меньше. Попытайтесь снова.");
                Restart();
            }
        }

        /// <summary>
        /// Сброс значений на дефолтные
        /// </summary>
        private void Restart()
        {
            currentNumber = 0;
            count = 0;
            lblCommandCount.Text = "Количество ваших ходов: 0";
            lblNumber.Text = "0";
            values.Clear();
        }

        /// <summary>
        /// Отмена действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (values.Count != 0)
            {
                currentNumber = values.Pop();
                lblNumber.Text = currentNumber.ToString();
                lblCommandCount.Text = $"Количество ваших ходов: {--count}";
            }
        }
    }
}
