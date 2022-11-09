namespace liczydlo
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.C_button = new System.Windows.Forms.Button();
            this.modulo_button = new System.Windows.Forms.Button();
            this.backspace_button = new System.Windows.Forms.Button();
            this.devide_button = new System.Windows.Forms.Button();
            this.multiple_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.equel_button = new System.Windows.Forms.Button();
            this.dot_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.double_zero_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.ones_button = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(33, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(468, 80);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // C_button
            // 
            this.C_button.Location = new System.Drawing.Point(69, 159);
            this.C_button.Name = "C_button";
            this.C_button.Size = new System.Drawing.Size(75, 23);
            this.C_button.TabIndex = 1;
            this.C_button.Text = "C";
            this.C_button.UseVisualStyleBackColor = true;
            this.C_button.Click += new System.EventHandler(this.C_button_Click);
            // 
            // modulo_button
            // 
            this.modulo_button.Location = new System.Drawing.Point(179, 159);
            this.modulo_button.Name = "modulo_button";
            this.modulo_button.Size = new System.Drawing.Size(75, 23);
            this.modulo_button.TabIndex = 2;
            this.modulo_button.Text = "%";
            this.modulo_button.UseVisualStyleBackColor = true;
            this.modulo_button.Click += new System.EventHandler(this.modulo_button_Click);
            // 
            // backspace_button
            // 
            this.backspace_button.Location = new System.Drawing.Point(285, 159);
            this.backspace_button.Name = "backspace_button";
            this.backspace_button.Size = new System.Drawing.Size(75, 23);
            this.backspace_button.TabIndex = 3;
            this.backspace_button.Text = "Backspace";
            this.backspace_button.UseVisualStyleBackColor = true;
            this.backspace_button.Click += new System.EventHandler(this.backspace_button_Click);
            // 
            // devide_button
            // 
            this.devide_button.Location = new System.Drawing.Point(398, 159);
            this.devide_button.Name = "devide_button";
            this.devide_button.Size = new System.Drawing.Size(75, 23);
            this.devide_button.TabIndex = 4;
            this.devide_button.Text = "/";
            this.devide_button.UseVisualStyleBackColor = true;
            this.devide_button.Click += new System.EventHandler(this.devide_button_Click);
            // 
            // multiple_button
            // 
            this.multiple_button.Location = new System.Drawing.Point(398, 207);
            this.multiple_button.Name = "multiple_button";
            this.multiple_button.Size = new System.Drawing.Size(75, 23);
            this.multiple_button.TabIndex = 8;
            this.multiple_button.Text = "*";
            this.multiple_button.UseVisualStyleBackColor = true;
            this.multiple_button.Click += new System.EventHandler(this.multiple_button_Click);
            // 
            // nine_button
            // 
            this.nine_button.Location = new System.Drawing.Point(285, 207);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(75, 23);
            this.nine_button.TabIndex = 7;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.nine_button_Click);
            // 
            // eight_button
            // 
            this.eight_button.Location = new System.Drawing.Point(179, 207);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(75, 23);
            this.eight_button.TabIndex = 6;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.eight_button_Click);
            // 
            // seven_button
            // 
            this.seven_button.Location = new System.Drawing.Point(69, 207);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(75, 23);
            this.seven_button.TabIndex = 5;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.seven_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(398, 259);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(75, 23);
            this.minus_button.TabIndex = 12;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            //
            // six_button
            // 
            this.six_button.Location = new System.Drawing.Point(285, 259);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(75, 23);
            this.six_button.TabIndex = 11;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.six_button_Click);
            // 
            // five_button
            // 
            this.five_button.Location = new System.Drawing.Point(179, 259);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(75, 23);
            this.five_button.TabIndex = 10;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.five_button_Click);
            // 
            // four_button
            // 
            this.four_button.Location = new System.Drawing.Point(69, 259);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(75, 23);
            this.four_button.TabIndex = 9;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.four_button_Click);
            // 
            // equel_button
            // 
            this.equel_button.Location = new System.Drawing.Point(398, 361);
            this.equel_button.Name = "equel_button";
            this.equel_button.Size = new System.Drawing.Size(75, 23);
            this.equel_button.TabIndex = 20;
            this.equel_button.Text = "=";
            this.equel_button.UseVisualStyleBackColor = true;
            this.equel_button.Click += new System.EventHandler(this.equel_button_Click);
            // 
            // dot_button
            // 
            this.dot_button.Location = new System.Drawing.Point(285, 361);
            this.dot_button.Name = "dot_button";
            this.dot_button.Size = new System.Drawing.Size(75, 23);
            this.dot_button.TabIndex = 19;
            this.dot_button.Text = ".";
            this.dot_button.UseVisualStyleBackColor = true;
            this.dot_button.Click += new System.EventHandler(this.dot_button_Click);
            // 
            // zero_button
            // 
            this.zero_button.Location = new System.Drawing.Point(179, 361);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(75, 23);
            this.zero_button.TabIndex = 18;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.zero_button_Click);
            // 
            // double_zero_button
            // 
            this.double_zero_button.Location = new System.Drawing.Point(69, 361);
            this.double_zero_button.Name = "double_zero_button";
            this.double_zero_button.Size = new System.Drawing.Size(75, 23);
            this.double_zero_button.TabIndex = 17;
            this.double_zero_button.Text = "00";
            this.double_zero_button.UseVisualStyleBackColor = true;
            this.double_zero_button.Click += new System.EventHandler(this.double_zero_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.Location = new System.Drawing.Point(398, 309);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(75, 23);
            this.plus_button.TabIndex = 16;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // three_button
            // 
            this.three_button.Location = new System.Drawing.Point(285, 309);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(75, 23);
            this.three_button.TabIndex = 15;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.three_button_Click);
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(179, 309);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(75, 23);
            this.two_button.TabIndex = 14;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.two_button_Click);
            // 
            // ones_button
            // 
            this.ones_button.Location = new System.Drawing.Point(69, 309);
            this.ones_button.Name = "ones_button";
            this.ones_button.Size = new System.Drawing.Size(75, 23);
            this.ones_button.TabIndex = 13;
            this.ones_button.Text = "1";
            this.ones_button.UseVisualStyleBackColor = true;
            this.ones_button.Click += new System.EventHandler(this.ones_button_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(215, 23);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 428);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.equel_button);
            this.Controls.Add(this.dot_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.double_zero_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.ones_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.multiple_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.devide_button);
            this.Controls.Add(this.backspace_button);
            this.Controls.Add(this.modulo_button);
            this.Controls.Add(this.C_button);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(553, 471);
            this.MinimumSize = new System.Drawing.Size(553, 471);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button C_button;
        private System.Windows.Forms.Button modulo_button;
        private System.Windows.Forms.Button backspace_button;
        private System.Windows.Forms.Button devide_button;
        private System.Windows.Forms.Button multiple_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button equel_button;
        private System.Windows.Forms.Button dot_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button double_zero_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button ones_button;
        private System.Windows.Forms.Label errorLabel;
    }
}

