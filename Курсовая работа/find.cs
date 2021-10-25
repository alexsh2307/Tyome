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
    public partial class find : Form
    {
        private startScreen startScreen;
        internal find(startScreen s)
        {
            startScreen = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(student a in startScreen.students)
            {
                if(a.name == textBox1.Text)
                {
                    textBox2.Text = a.age.ToString();
                    comboBox1.Text = a.klass.number.ToString();
                    comboBox2.Text = a.klass.symbol.ToString();
                    comboBox3.Text = a.sex;
                    comboBox4.Text = a.attendance ? "Да" : "Нет";
                    comboBox5.Text = a.academic_performance;
                    comboBox6.Text = a.foreign ? "Да" : "Нет";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            startScreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (student a in startScreen.students)
            {
                if (a.name == textBox1.Text)
                {
                    bool f = true;

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
                        klass = new Klass(Int32.Parse(comboBox1.Text), Char.Parse(comboBox2.Text));
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
                        a.age = age;
                        a.klass = klass;
                        a.sex = sex;
                        a.attendance = attendance;
                        a.academic_performance = academic_performance;
                        a.foreign = foreign;
                        foreach(ListViewItem b in startScreen.listView1.Items)
                        {
                            if (b.Text == a.name)
                            {
                                b.SubItems[1].Text = a.age.ToString();
                                b.SubItems[2].Text = a.klass.ToString();
                                b.SubItems[3].Text = a.sex;
                                b.SubItems[4].Text = a.attendance ? "Да" : "Нет";
                                b.SubItems[5].Text = a.academic_performance;
                                b.SubItems[6].Text = a.foreign ? "Да" : "Нет";
                                break;
                            }
                        }
                       
                        startScreen.Show();
                        this.Close();
                    }
                }
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
