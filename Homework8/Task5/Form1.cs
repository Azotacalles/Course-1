using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        //Родыгин
        //Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок)
        StudentCollection database = new StudentCollection();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открываем файл CSV для преобразования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                while (!sr.EndOfStream)
                {
                    string[] info = sr.ReadLine().Split(';');
                    database.Add(info[0], info[1], info[2], info[3], info[4], int.Parse(info[5]), int.Parse(info[6]), int.Parse(info[7]), info[8]);
                }
                database.path = ofd.FileName;
            }
            database.Save(database.path.Replace(".csv", ".xml"));
        }
    }
}
