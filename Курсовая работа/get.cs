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

namespace Курсовая_работа
{
    public partial class get : Form
    {
        private startScreen startScreen;
        public get(startScreen s)
        {
            InitializeComponent();
            startScreen = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBox1.Text;
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] str = line.Split(',');
                    startScreen.students.Add(new student(str[0].Trim(), Convert.ToInt32(str[1].Trim()), new Klass(str[2].Trim()), str[3].Trim(), Convert.ToBoolean(str[4].Trim()), str[5].Trim(), Convert.ToBoolean(str[6].Trim())));
                }
                startScreen.showList();
                startScreen.Show();
                this.Close();
            }
            catch
            {
                textBox1.BackColor = Color.Red;
            }
        }
    }
}
