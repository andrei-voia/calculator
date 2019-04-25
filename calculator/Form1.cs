using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Text = "0";
        }

        float n, aux;
        int ticket;

        //initializare numere:
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "1";
            else textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "2";
            else textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "3";
            else textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "4";
            else textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "5";
            else textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "6";
            else textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "7";
            else textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "8";
            else textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "9";
            else textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="0")
            textBox1.Text += 0;
        }


        void punct()   //verificare existenta punct in numar
        {
                string lungime;
                char cauta;
                int ok = 1;

                lungime = textBox1.Text;
                for (int i = 1; i < lungime.Length; i++)
                {
                    cauta = Convert.ToChar(lungime[i]);
                    if (cauta == '.') ok = 0;
                }
                if (ok == 1) button20.Enabled = true;
                else button20.Enabled = false;
        }


        private void button16_Click(object sender, EventArgs e)  // operator CE (stergere)
        {
            textBox1.Clear();
            textBox2.Clear();
            button20.Enabled = true;
            textBox1.Text = "0";
        }

        //initializare operatori:
        private void button11_Click(object sender, EventArgs e)
        {
            if (ticket == 1)
            {
                textBox2.Clear();
               n = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Convert.ToString(aux + n);
                n = Convert.ToSingle(textBox1.Text);
                ticket = 0;
                punct();
            }

            if (ticket == 2)
            {
                textBox2.Clear();
               n = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Convert.ToString(aux - n);
                n = Convert.ToSingle(textBox1.Text);
                ticket = 0;
                punct();
            }

            if (ticket == 3)
            {
                textBox2.Clear();
                n = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Convert.ToString(aux * n);
                n = Convert.ToSingle(textBox1.Text);
                ticket = 0;
                punct();
            }

            if (ticket == 4)
            {
                textBox2.Clear();
                n = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Convert.ToString(aux / n);
                n = Convert.ToSingle(textBox1.Text);
                ticket = 0;
                punct();
            }

            if (ticket == 5) 
            {
                textBox2.Clear();
                n = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Convert.ToString(aux % n);
                n = Convert.ToSingle(textBox1.Text);
                ticket = 0;
                punct();
            }
        }

        
        private void button12_Click(object sender, EventArgs e)  //operator adunare
        {
            textBox2.Text = textBox1.Text+"+";
            n = Convert.ToSingle(textBox1.Text);
            aux = n;
            textBox1.Clear();
            textBox1.Text = "0";
            ticket = 1;
            button20.Enabled = true;
        }


        private void button13_Click(object sender, EventArgs e)  //operator scadere
        {
            textBox2.Text = textBox1.Text + "-";
            n = Convert.ToSingle(textBox1.Text);
            aux = n;
            textBox1.Clear();
            textBox1.Text = "0";
            ticket = 2;
            button20.Enabled = true;
        }


        private void button14_Click(object sender, EventArgs e)  //operator inmultire
        {
            textBox2.Text = textBox1.Text + "x";
            n = Convert.ToSingle(textBox1.Text);
            aux = n;
            textBox1.Clear();
            textBox1.Text = "0";
            ticket = 3;
            button20.Enabled = true;
        }


        private void button15_Click(object sender, EventArgs e)  //operator impartire
        {
            textBox2.Text = textBox1.Text + "/";
            n = Convert.ToSingle(textBox1.Text);
            aux = n;
            textBox1.Clear();
            textBox1.Text = "0";
            ticket = 4;
            button20.Enabled = true;
        }


        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + "%";
            n = Convert.ToSingle(textBox1.Text);
            aux = n;
            textBox1.Clear();
            textBox1.Text = "0";
            ticket = 5;
            button20.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)  //operator patrat
        {
            n = Convert.ToSingle(textBox1.Text);
            textBox1.Text = Convert.ToString(n * n);
            textBox2.Text = "sqr(" + n + ")";
            punct();
        }


        private void button18_Click(object sender, EventArgs e)  //operator radical
        {
            n = Convert.ToSingle(textBox1.Text);
            if (n < 0) textBox1.Text = "Invalid imput";
            else
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(n));
                textBox2.Text = "sqrt(" + n + ")";
                punct();
            }
        }

        
        private void button19_Click(object sender, EventArgs e)  //operator 1/x (fractie)
        {
            n = Convert.ToSingle(textBox1.Text);
            textBox1.Text = Convert.ToString(1/n);
            textBox2.Text = "1/" + n;
            punct();

        }
        

        private void button20_Click(object sender, EventArgs e) // punct / virgula
        {
            if (button20.Enabled == true && textBox1.Text != "")
            {
                textBox1.Text += ".";
                button20.Enabled = false;
            }

        }


        private void button22_Click(object sender, EventArgs e)  //operator plus / minus
        {
            if(textBox1.Text!="0")
            {
                n = Convert.ToSingle(textBox1.Text);
                if (n != 0) textBox1.Text = Convert.ToString(-n);
            }
        }


        private void button21_Click(object sender, EventArgs e) //operator DELETE
        {
            if(textBox1.Text!="0")
            {
                string lungime;
                char [] cifra=new char[20];

                lungime = textBox1.Text;
                textBox1.Text = "";

                for (int i = 0; i < lungime.Length - 1; i++) 
                    cifra[i] = Convert.ToChar(lungime[i]);
                for (int i = 0; i < lungime.Length - 1; i++) 
                    textBox1.Text += cifra[i];

                punct();
            }
        }
    }
}
