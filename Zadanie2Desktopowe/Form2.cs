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

namespace Zadanie2Desktopowe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\student\\source\\repos\\Kakaoss\\Zadanie2Desktopowe\\uczen.txt");

            if (comboBox1.Text == "Imie")
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
