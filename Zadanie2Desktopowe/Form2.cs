using System;
using System.Collections;
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
            string[][] tablica;
            string linia;
            string wynik = "";
            List<string[]> lista = new List<string[]>();
            while ((linia = sr.ReadLine()) != null)
            {
                string[] tablica2 = linia.Split(';');
                lista.Add(tablica2);
            }
            tablica = lista.ToArray();
            sr.Close();
            int i;
            if (comboBox1.Text == "Imie")
            {
                i = 1;
            }
            else if (comboBox1.Text == "Nazwisko")
            {
                i = 2;
            }
            else
            {
                i = 3;
            }
            if (comboBox2.Text == "jest równe")
            {
                for (int j = 1; j < tablica.Length; j++)
                {
                    if (tablica[j][i] == textBox4.Text)
                    {
                        wynik += tablica[j][0] + ";" + tablica[j][1] + ";" + tablica[j][2] + ";" + tablica[j][3] + Environment.NewLine;
                    }
                }
            }
            else if (comboBox2.Text == "rozpoczyna sie od")
            {
                for (int j = 1; j < tablica.Length; j++)
                {
                    if (tablica[j][i].StartsWith(textBox4.Text))
                    {
                        wynik += tablica[j][0] + ";" + tablica[j][1] + ";" + tablica[j][2] + ";" + tablica[j][3] + Environment.NewLine;
                    }
                }
            }
            else
            {
                for (int j = 1; j < tablica.Length; j++)
                {
                    if (tablica[j][i].Contains(textBox4.Text))
                    {
                        wynik += tablica[j][0] + ";" + tablica[j][1] + ";" + tablica[j][2] + ";" + tablica[j][3] + Environment.NewLine;
                    }
                }
            }
            richTextBox1.Text = wynik;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
