﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liczydlo
{

    public partial class Form1 : Form
    {
        public bool bylo = false;


        public string returneedVal()
        {
            string strVar = textBox1.Text;
            return strVar;
        }

        public bool returnedBool()
        {
            return bylo;
        }

        static Double Eval(String expression)
        {
            if (!(expression.Contains('E')))
            {
                System.Data.DataTable table = new System.Data.DataTable();
                return Convert.ToDouble(table.Compute(expression, String.Empty));
            }
            return 0;
        }

        public void addButtonValue(object sender)
        {
            functions fnc = new functions();
            //funkcja dodajTres zwraca stringa
            textBox1.Text = textBox1.Text + fnc.dodajTresc(sender);
        }

        public void addOperatorValue(object sender)
        {
            returneedVal();
            bylo = false;
            functions fnc = new functions();
            textBox1.Text = textBox1.Text + fnc.dodaj_znak_specjalny(sender);
        }

        /*public void dodajTresc(object ll)
        {
            var btn = ll as Button;
            if (btn != null)
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }
        }*/

        /*public void dodaj_znak_specjalny(object ll)
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
                }
                else if (last != char.Parse(btn.Text))
                {
                    bylo = false;
                    if (btn != null)
                    {
                        textBox1.Text = textBox1.Text + btn.Text;
                    }
                }
            }
        }*/


        public Form1()
        {
            InitializeComponent();
        }

        // C
        private void C_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            errorLabel.Text = "";
            bylo = false;
        }

        // %
        private void modulo_button_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(".")))
            {

                //dodaj_znak_specjalny(sender);
                addButtonValue(sender);
                
            }
        }

        // Backspace
        private void backspace_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        // /
        private void devide_button_Click(object sender, EventArgs e)
        {
            //dodaj_znak_specjalny(sender);
            addButtonValue(sender);

        }

        // 00
        private void double_zero_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // 7
        private void seven_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // 8
        private void eight_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // 9
        private void nine_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // *
        private void multiple_button_Click(object sender, EventArgs e)
        {
            //dodaj_znak_specjalny(sender);
            addButtonValue(sender);
        }

        // 4
        private void four_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // 5
        private void five_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // 6
        private void six_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // -
        private void minus_button_Click(object sender, EventArgs e)
        {
            //dodaj_znak_specjalny(sender);
            addButtonValue(sender);
        }

        // 1
        private void ones_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);

        }

        // 2
        private void two_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // 3
        private void three_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // +
        private void plus_button_Click(object sender, EventArgs e)
        {
            //dodaj_znak_specjalny(sender);
            addButtonValue(sender);
        }

        // 0
        private void zero_button_Click(object sender, EventArgs e)
        {
            /*dodajTresc(sender);*/
            addButtonValue(sender);
        }

        // znak: '.'
        private void dot_button_Click(object sender, EventArgs e)
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
                        /*dodajTresc(sender);*/
                        addButtonValue(sender);
                    }
                }
            }
        }

        // =
        private void equel_button_Click(object sender, EventArgs e)
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