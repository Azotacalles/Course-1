using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        FilmCollection database;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Новый файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new FilmCollection(sfd.FileName);
                database.Save();
                nudNumber.Minimum = 0;
                nudNumber.Maximum = 0;
                nudNumber.Value = 0;
            };
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new FilmCollection(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Добавить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add(tbName.Text, tbGenre.Text, int.Parse(tbYear.Text));
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
            nudNumber.Minimum = 1;
        }

        /// <summary>
        /// Удалить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        /// <summary>
        /// Выбор элемента по номеру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            int index = (int)nudNumber.Value;
            if (index > 0)
            {
                index--;
                tbCollection.Text = database[index].name + database[index].genre + database[index].year.ToString();
            }
        }
    }
}
