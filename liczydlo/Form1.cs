﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liczydlo
{

    public partial class Form1 : Form
    {
        public bool bylo = false;

        static Double Eval(String expression)
        {
            if (!(expression.Contains('E')))
            {
                System.Data.DataTable table = new System.Data.DataTable();
                return Convert.ToDouble(table.Compute(expression, String.Empty));
            }
            return 0;
        }

        public void dodajTresc(object ll)
        {
            var btn = ll as Button;
            if (btn != null)
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
        }
        public void dodaj_znak_specjalny(object ll)
        {
            var btn = ll as Button;
            string test = textBox1.Text;
            if (test.Length != 0)
            {
                char[] chars = { '+', '-', '/', '*', '%' };
                char last = test[test.Length - 1];

                if (chars.Any(x => textBox1.Text.EndsWith(char.ToString(x))))
                {
                    bylo = false;
                    if (btn != null)
                    {
                        string current_text = textBox1.Text;
                        textBox1.Text = current_text.Remove(current_text.Length - 1, 1) + btn.Text;
                    }
                } else if (last != char.Parse(btn.Text))
                {
                    bylo = false;
                    if (btn != null)
                    {
                        textBox1.Text = textBox1.Text + btn.Text;
                    }
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        // C
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            errorLabel.Text = "";
            bylo = false;
        }

        // %
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(".")))
            {
                dodaj_znak_specjalny(sender);
            }
        }

        // Backspace
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        // /
        private void button4_Click(object sender, EventArgs e)
        {
            dodaj_znak_specjalny(sender);

        }

        // 00
        private void button16_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // 7
        private void button8_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // 8
        private void button7_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // 9
        private void button6_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // *
        private void button5_Click(object sender, EventArgs e)
        {
            dodaj_znak_specjalny(sender);
        }

        // 4
        private void button12_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // 5
        private void button11_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // 6
        private void button10_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // -
        private void button9_Click(object sender, EventArgs e)
        {
            dodaj_znak_specjalny(sender);
        }

        // 1
        private void button20_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);

        }

        // 2
        private void button19_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // 3
        private void button18_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // +
        private void button17_Click(object sender, EventArgs e)
        {
            dodaj_znak_specjalny(sender);
        }

        // 0
        private void button15_Click(object sender, EventArgs e)
        {
            dodajTresc(sender);
        }

        // znak: '.'
        private void button14_Click(object sender, EventArgs e)
        {

            string test = textBox1.Text;
            if (!bylo)
            {
                bylo = true;
                if (test.Length == 0)
                {
                    textBox1.Text = "0.";
                }
                if ((test.Length != 0) && (textBox1.Text != "0."))
                {
                    char[] chars = { '%', '*', '/', '+', '-' };
                    if (chars.Any(x => textBox1.Text.EndsWith(char.ToString(x))))
                    {
                        textBox1.Text += "0.";
                    }
                    else
                    {
                        dodajTresc(sender);
                    }
                }
            }
        }

        // =
        private void button13_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            string test = textBox1.Text;
            if (test.Length != 0)
            {
                string lastchar = test[test.Length - 1] + " ";
                bool b = new char[] { '%', '*', '/', '+', '-' }.Any(s => lastchar.Contains(s));
                if (!b)
                {
                    if (test.Contains('E'))
                    {
                        errorLabel.Text = "Przeciążno zmienną";
                    }
                    if (test.Contains(','))
                    {
                        for(int i = 0; i < test.Length; i++)
                        {
                            if(test[i] == ',')
                            {
                                textBox1.Text = textBox1.Text.Remove(i, 1).Insert(i, ".");
                            }
                        }
                    }
                    Double cnvrt = Eval(textBox1.Text);
                    if(cnvrt.ToString() == "∞" || cnvrt.ToString() == "NaN")
                    {
                        errorLabel.Text = "Nie dzielimy przez 0";
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (cnvrt.ToString().Contains(","))
                        {
                            bylo = true;
                        }
                        textBox1.Text = cnvrt.ToString();
                    }

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void errorLabel_Click(object sender, EventArgs e)
        {

        }


    }
}