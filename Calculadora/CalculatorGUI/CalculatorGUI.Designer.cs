namespace Calculadora
{
    partial class CalculatorGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.historicButton = new System.Windows.Forms.Button();
            this.closeParenthesesButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.percentageButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayTextBox.Location = new System.Drawing.Point(12, 15);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(449, 106);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // historicButton
            // 
            this.historicButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.historicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historicButton.Location = new System.Drawing.Point(12, 150);
            this.historicButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.historicButton.Name = "historicButton";
            this.historicButton.Size = new System.Drawing.Size(98, 114);
            this.historicButton.TabIndex = 1;
            this.historicButton.Text = "H";
            this.historicButton.UseVisualStyleBackColor = false;
            this.historicButton.Click += new System.EventHandler(this.historicButton_Click);
            // 
            // closeParenthesesButton
            // 
            this.closeParenthesesButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.closeParenthesesButton.Enabled = false;
            this.closeParenthesesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeParenthesesButton.Location = new System.Drawing.Point(128, 150);
            this.closeParenthesesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeParenthesesButton.Name = "closeParenthesesButton";
            this.closeParenthesesButton.Size = new System.Drawing.Size(98, 114);
            this.closeParenthesesButton.TabIndex = 2;
            this.closeParenthesesButton.Text = "√";
            this.closeParenthesesButton.UseVisualStyleBackColor = false;
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eraseButton.Enabled = false;
            this.eraseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eraseButton.Location = new System.Drawing.Point(244, 150);
            this.eraseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(98, 114);
            this.eraseButton.TabIndex = 3;
            this.eraseButton.Text = "C";
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.Location = new System.Drawing.Point(12, 291);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(98, 114);
            this.sevenButton.TabIndex = 4;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eightButton.Location = new System.Drawing.Point(128, 291);
            this.eightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(98, 114);
            this.eightButton.TabIndex = 5;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nineButton.Location = new System.Drawing.Point(244, 291);
            this.nineButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(98, 114);
            this.nineButton.TabIndex = 6;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.divisionButton.Enabled = false;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divisionButton.Location = new System.Drawing.Point(360, 150);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(98, 114);
            this.divisionButton.TabIndex = 7;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.multiplicationButton.Enabled = false;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplicationButton.Location = new System.Drawing.Point(360, 291);
            this.multiplicationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(98, 114);
            this.multiplicationButton.TabIndex = 8;
            this.multiplicationButton.Text = "x";
            this.multiplicationButton.UseVisualStyleBackColor = false;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fourButton.Location = new System.Drawing.Point(12, 432);
            this.fourButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(98, 114);
            this.fourButton.TabIndex = 9;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.Location = new System.Drawing.Point(128, 432);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(98, 114);
            this.fiveButton.TabIndex = 10;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sixButton.Location = new System.Drawing.Point(244, 432);
            this.sixButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(98, 114);
            this.sixButton.TabIndex = 11;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractionButton.Location = new System.Drawing.Point(360, 432);
            this.subtractionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(98, 114);
            this.subtractionButton.TabIndex = 12;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = false;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneButton.Location = new System.Drawing.Point(12, 580);
            this.oneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(98, 114);
            this.oneButton.TabIndex = 13;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoButton.Location = new System.Drawing.Point(128, 580);
            this.twoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(98, 114);
            this.twoButton.TabIndex = 14;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeButton.Location = new System.Drawing.Point(244, 580);
            this.threeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(98, 114);
            this.threeButton.TabIndex = 15;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.additionButton.Location = new System.Drawing.Point(360, 580);
            this.additionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(98, 114);
            this.additionButton.TabIndex = 16;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = false;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // percentageButton
            // 
            this.percentageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.percentageButton.Enabled = false;
            this.percentageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentageButton.Location = new System.Drawing.Point(12, 719);
            this.percentageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.percentageButton.Name = "percentageButton";
            this.percentageButton.Size = new System.Drawing.Size(98, 114);
            this.percentageButton.TabIndex = 17;
            this.percentageButton.Text = "%";
            this.percentageButton.UseVisualStyleBackColor = false;
            this.percentageButton.Click += new System.EventHandler(this.percentageButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.Location = new System.Drawing.Point(128, 719);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(98, 114);
            this.zeroButton.TabIndex = 18;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // commaButton
            // 
            this.commaButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.commaButton.Enabled = false;
            this.commaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commaButton.Location = new System.Drawing.Point(244, 719);
            this.commaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(98, 114);
            this.commaButton.TabIndex = 19;
            this.commaButton.Text = ",";
            this.commaButton.UseVisualStyleBackColor = false;
            this.commaButton.Click += new System.EventHandler(this.commaButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.equalButton.Enabled = false;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalButton.Location = new System.Drawing.Point(360, 719);
            this.equalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(98, 114);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // CalculadoraGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(473, 852);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.percentageButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.historicButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.closeParenthesesButton);
            this.Controls.Add(this.displayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CalculadoraGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button historicButton;
        private System.Windows.Forms.Button closeParenthesesButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button percentageButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button equalButton;
    }
}

