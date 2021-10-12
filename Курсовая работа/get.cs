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
                    string[] str = line.Split(' ');
                    startScreen.Students.Add(new student(str[0], Convert.ToInt32(str[1]), new Klass(str[2]), str[3], Convert.ToBoolean(str[4]), str[5], Convert.ToBoolean(str[6])));
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
