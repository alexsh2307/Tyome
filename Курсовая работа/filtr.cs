using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class filtr : Form
    {
        private startScreen startScreen;
        public filtr(startScreen a)
        {
            InitializeComponent();
            startScreen = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p = "^.*" + textBox1.Text + ".*$";
            List<student> copyList = new List<student>();

            for (int i = 0; i < startScreen.students.Count; i++)
            {
                if (Regex.IsMatch(startScreen.students[i].name, p))
                {
                    copyList.Add(startScreen.students[i]);
                }
            }
            startScreen.hideList();
            foreach (student valuePair in copyList)
            {
                startScreen.show(valuePair);
            }
            startScreen.Show();
            this.Close();
        }
    }
}
