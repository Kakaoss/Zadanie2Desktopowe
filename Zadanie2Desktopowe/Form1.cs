using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2Desktopowe
{
    public partial class Form1 : Form
    {
        public Image obr1 = Image.FromFile(@"C:\Users\student\source\repos\Kakaoss\Zadanie2Desktopowe\1.png");
        public Image obr2 = Image.FromFile(@"C:\Users\student\source\repos\Kakaoss\Zadanie2Desktopowe\2.png");
        public Image obr3 = Image.FromFile(@"C:\Users\student\source\repos\Kakaoss\Zadanie2Desktopowe\3.png");
        public Image obr4 = Image.FromFile(@"C:\Users\student\source\repos\Kakaoss\Zadanie2Desktopowe\4.png");
        public Image obr5 = Image.FromFile(@"C:\Users\student\source\repos\Kakaoss\Zadanie2Desktopowe\5.png");
        public Image obr6 = Image.FromFile(@"C:\Users\student\source\repos\Kakaoss\Zadanie2Desktopowe\6.png");
        public string textobr;
        public Form1()
        {
            InitializeComponent();
        }
        private void losowanie_obrazka()
        {
            Random generator = new Random();
            int a = generator.Next(1, 7);
            switch (a)
            {
                case 1:
                    pictureBox1.Image = obr1;
                    textobr = "mxyxw";
                    break;
                case 2:
                    pictureBox1.Image = obr2;
                    textobr = "b5nmm";
                    break;
                case 3:
                    pictureBox1.Image = obr3;
                    textobr = "74853";
                    break;
                case 4:
                    pictureBox1.Image = obr4;
                    textobr = "cg5dd";
                    break;
                case 5:
                    pictureBox1.Image = obr5;
                    textobr = "x3deb";
                    break;
                case 6:
                    pictureBox1.Image = obr6;
                    textobr = "befhd";
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var popr_nazwa = "admin";
            var popr_haslo = "Qwerty1@34";
            var nazwa = textBox2.Text;
            var haslo = textBox1.Text;
            var captcha = textBox3.Text;
            if(nazwa == popr_nazwa)
            {
                if(haslo == popr_haslo)
                {
                    if (textobr == captcha)
                    {
                        Form2 f2 = new Form2();
                        MessageBox.Show("Poprawnie zalogowano");
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        losowanie_obrazka();
                        textBox3.Text = "";
                        MessageBox.Show("Nie poprawnie podana captcha");
                    }
                }
                else
                {
                    MessageBox.Show("Nie poprawne haslo");
                }
            }
            else
            {
                MessageBox.Show("Nie poprawna nazwa");
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            losowanie_obrazka();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            losowanie_obrazka();
        }
    }
}
