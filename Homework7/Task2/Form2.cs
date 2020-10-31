using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form2 : Form
    {
        int number = 0;
        int count = 0;
        public Form2()
        {
            InitializeComponent();
            Random random = new Random();
            number = random.Next(1, 101);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            count++;
            int temp = int.Parse(tbNumber.Text);
            if (temp > number) lblAnswer.Text = "Ваше число больше!";
            else if (temp < number) lblAnswer.Text = "Ваше число меньше!";
            else
            {
                MessageBox.Show($"Вы угадали за {count} ходов", "Отлично!");
                this.Close();
            }
        }
    }
}
