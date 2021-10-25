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
    public partial class save : Form
    {
        private startScreen startScreen;
        public save(startScreen s)
        {
            InitializeComponent();
            startScreen = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = Color.White;
                StreamWriter sw = File.CreateText(textBox1.Text);
                foreach (student a in startScreen.students)
                {
                    sw.WriteLine(a.ToString());
                }
                sw.Close();
                this.Close();
                startScreen.Show();
            }
            catch
            {
                textBox1.BackColor = Color.Red;
            }
        }
    }
}
