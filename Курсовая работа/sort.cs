using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class sort : Form
    {
        private startScreen startScreen;
        internal sort(startScreen s)
        {
            startScreen = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                if(comboBox1.Text == "Название")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.name).ToList();
                }

                if (comboBox1.Text == "Возраст")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.age).ToList();
                }

                if (comboBox1.Text == "Класс")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.klass).ToList();
                }

                if (comboBox1.Text == "Пол")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.sex).ToList();
                }

                if (comboBox1.Text == "Посещаемость")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.attendance).ToList();
                }

                if (comboBox1.Text == "Успеваемость")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.academic_performance).ToList();
                }

                if (comboBox1.Text == "Иностранец")
                {
                    startScreen.Students = startScreen.Students.OrderBy(si => si.foreign).ToList();
                }

                startScreen.hideList();
                startScreen.showList();
                startScreen.Show();
                this.Close();
            }
            else
            {
                comboBox1.BackColor = Color.Red;
            }
        }

        public int Compare(string[] o1, string[] o2)
        {
            if (o1[0].Length > o2[0].Length)
            {
                return 1;
            }
            else if (o1[0].Length < o2[0].Length)
            {
                return -1;
            }

            return 0;
        }
    }
}
