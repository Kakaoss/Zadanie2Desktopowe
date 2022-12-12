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
            StreamReader sr = new StreamReader("C:\\Users\\student\\source\\repos\\Kakaoss\\Zadanie2Desktopowe\\uczen.txt");

            var imie = textBox1.Text;
            var nazwisko = textBox2.Text;
            var klasa = textBox3.Text;

            if (imie == "" || nazwisko == "" || klasa == "")
                MessageBox.Show("Dane musza byc uzupelnione");
            else
            {
                int liczba = 0;
                string linia;
                string id_ucznia = "";
                while ((linia = sr.ReadLine()) != null)
                {
                    liczba++;
                }
                if (liczba >= 100)
                {
                    id_ucznia += liczba.ToString();
                }
                else if (liczba >= 10)
                {
                    id_ucznia += "0" + liczba.ToString();
                }
                else
                {
                    id_ucznia += "00" + liczba.ToString();
                }
                sr.Close();

                StreamWriter sw = new StreamWriter(@"C:\\Users\\student\\source\\repos\\Kakaoss\\Zadanie2Desktopowe\\uczen.txt");
                string do_dopisania = $"{id_ucznia};{imie};{nazwisko};{klasa}";
                sw.Write(Environment.NewLine + do_dopisania);
                sw.Close();
            }

        }
    }
}
