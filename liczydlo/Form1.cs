using System;
using System.Linq;
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

        public void backButton()
        {
            bool b = new string[] { "Duża liczba", "Nie dzielimy przez 0", "error" }.Any(s => textBox1.Text.Contains(s));
            if (b)
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }


        public void addButtonValue(object sender)
        {
            dodajTresc dt = new dodajTresc();
            if (!(textBox1.Text == "Nie dzielimy przez 0" || textBox1.Text == "Duża liczba"))
            {
                //funkcja dodajTres zwraca stringa
                textBox1.Text = textBox1.Text + dt.dodajTresc1(sender);
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + dt.dodajTresc1(sender);
            }
        }

        public void addOperatorValue(object sender)
        {
            bool b = new string[] { "Duża liczba", "Nie dzielimy przez 0", "error" }.Any(s => textBox1.Text.Contains(s));
            if (b)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.Length == 1 && textBox1.Text[0] == '-')
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = textBox1.Text + "0";
            }
            returneedVal();
            bylo = false;
            dodajznakspecjalny dzs = new dodajznakspecjalny();
            textBox1.Text = dzs.dodaj_znak_specjalny(sender, this);



        }

        public void addDot(object sender)
        {
            bool b = new string[] { "Duża liczba", "Nie dzielimy przez 0", "error" }.Any(s => textBox1.Text.Contains(s));
            if (b)
            {
                textBox1.Text = "";
            }
            dotbutton dts = new dotbutton();
            textBox1.Text = dts.dotButton(sender, this);
            bylo = true;
        }

        public void equalsButton()
        {
            equalsbutton eb = new equalsbutton();
            textBox1.Text = eb.equalsButton(this);
                
        }

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
                addOperatorValue(sender);

            }
        }

        // Backspace
        private void backspace_button_Click(object sender, EventArgs e)
        {
            backButton();
        }

        // /
        private void devide_button_Click(object sender, EventArgs e)
        {
            //dodaj_znak_specjalny(sender);
            addOperatorValue(sender);

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
            addOperatorValue(sender);
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
            if (textBox1.Text.Length != 0)
            {
                addOperatorValue(sender);
            }
            else
            {
                textBox1.Text += "-";
            }
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
            addOperatorValue(sender);
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

            addDot(sender);
        }

        // =
        private void equel_button_Click(object sender, EventArgs e)
        {
            equalsButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void przerzucKursorNaKoniec()
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] chars = { '+', '-', '/', '%', '*', '.' };
            char[] chars2 = { '+', '-', '/', '%', '*' };
            bool contained = chars.Any(s => e.KeyChar == s);
            bool b = new string[] { "Duża liczba", "Nie dzielimy przez 0", "error" }.Any(s => textBox1.Text.Contains(s));
            bool konczySieNaOperator = chars2.Any(x => (sender as TextBox).Text.EndsWith(char.ToString(x)));

            //Blokuje stringi
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            !(contained))
            {
                e.Handled = true;
            }

            //blokuje dublowanie się kropek
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //Jeżeli ostatni char jest operatorem i będziemy chcieli dać kolejnego operatora to podmieni starego
            if ((contained) && konczySieNaOperator && (e.KeyChar != '.'))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + e.KeyChar;
                // Przerzuca kursor na koniec
                przerzucKursorNaKoniec();
                e.Handled = true;
            }

            //Jeżeli działanie jest puste albo ostatnim charem jest operator to przed . dodaje się 0
            if ((contained) && textBox1.Text == "" || konczySieNaOperator && (e.KeyChar == '.'))
            {
                textBox1.Text = textBox1.Text + "0" + e.KeyChar;
                przerzucKursorNaKoniec();
                e.Handled = true;
            }

            //Backspace usuwwa całe napisy wynikające z nieprawidłowości
            if(e.KeyChar == (char)8)
            {
                if (b)
                {
                    textBox1.Text = "";
                }

            }

            //Przycisk enter wywołuje znak =
            if (e.KeyChar == (char)13)
            {
                equalsButton();
                if (b)
                {
                    equalsButton();
                }
                textBox1.Text = textBox1.Text.Replace(Environment.NewLine, "");
                przerzucKursorNaKoniec();
                e.Handled = false;
            }
        }
    }
}