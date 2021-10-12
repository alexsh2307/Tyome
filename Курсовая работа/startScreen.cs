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
    public partial class startScreen : Form
    {
        internal List<student> Students = new List<student>();
        public startScreen()
        {
            InitializeComponent();
        }

        public void showList()
        {
            hideList();
            foreach (student a in Students)
            {
                show(a);
            }
        }

        public void hideList()
        {
            foreach (ListViewItem b in listView1.Items)
            {
                b.Remove();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add add = new add(this);
            add.Show();
            this.Hide();
        }

        internal void show(student a)
        {
            listView1.Items.Add(new ListViewItem(new string[] {
                    a.name, a.age.ToString(), a.klass.ToString(), a.sex,
                    a.attendance ? "Да" : "Нет", a.academic_performance, a.foreign ? "Да" : "Нет"
                    }));
        }

        internal void Add(student a)
        {
            Students.Add(a);
            show(a);
        }

        internal void Del(student a)
        {
            Students.Remove(a);
            listView1.Items.Remove(new ListViewItem(new string[] {
                    a.name, a.age.ToString(), a.klass.ToString(), a.sex,
                    a.attendance ? "Да" : "Нет", a.academic_performance, a.foreign ? "Да" : "Нет"
                    }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool f = false;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
                f = true;
                for (int i = 0; i < Students.Count; i++)
                {
                    if(Students[i].name == item.Text)
                    {
                        Students.Remove(Students[i]);
                    }
                }
            }

            if (!f)
            {
                MessageBox.Show("Ни один элемент не выбран",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            find find = new find(this);
            find.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sort sort = new sort(this);
            this.Hide();
            sort.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showList();
        }
        
        private void button6_Click_1(object sender, EventArgs e)
        {
            hideList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            filtr filtr = new filtr(this);
            filtr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Students.Clear();
            showList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            save save = new save(this);
            save.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            get get = new get(this);
            get.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
