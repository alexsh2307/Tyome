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
    public partial class add : Form
    {
        private startScreen startScreen;
        internal add(startScreen s)
        {
            startScreen = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = true;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            comboBox4.BackColor = Color.White;
            comboBox5.BackColor = Color.White;
            comboBox6.BackColor = Color.White;

            if (textBox1.Text.Length == 0)
            {
                f = false;
                textBox1.BackColor = Color.Red;
            }

            int age;
            if (int.TryParse(textBox2.Text, out age) && textBox2.Text.Length > 0)
            {
                if (age < 0 || age > 19)
                {
                    textBox2.BackColor = Color.Red;
                    f = false;
                }
            }
            else
            {
                f = false;
                textBox2.BackColor = Color.Red;
            }

            Klass klass = new Klass(1, 'a');
            if (comboBox1.Text.Length > 0 && comboBox2.Text.Length > 0)
            {
                klass = new Klass (Int32.Parse(comboBox1.Text), Char.Parse(comboBox2.Text));
            }
            else
            {
                f = false;
                if (comboBox1.Text.Length == 0)
                    comboBox1.BackColor = Color.Red;
                if (comboBox2.Text.Length == 0)
                    comboBox2.BackColor = Color.Red;
            }

            string sex = "";
            if (comboBox3.Text.Length > 0)
            {
                sex = comboBox3.Text;
            }
            else
            {
                f = false;
                comboBox3.BackColor = Color.Red;
            }

            bool attendance = true;
            if (comboBox4.Text.Length > 0)
            {
                if (comboBox4.Text == "Нет")
                attendance = false;
            }
            else
            {
                f = false;
                comboBox4.BackColor = Color.Red;
            }

            string academic_performance = "";
            if (comboBox5.Text.Length > 0)
            {
                academic_performance = comboBox5.Text;
            }
            else
            {
                f = false;
                comboBox5.BackColor = Color.Red;
            }

            bool foreign = true;
            if (comboBox6.Text.Length > 0)
            {
                if (comboBox6.Text == "Нет")
                    foreign = false;
            }
            else
            {
                f = false;
                comboBox6.BackColor = Color.Red;
            }

            if (f)
            {
                student Students = new student(textBox1.Text, age, klass, sex, attendance, academic_performance, foreign);
                startScreen.Add(Students);
                startScreen.Show();
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
