using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculatorGUI : Form
    {
        public CalculatorGUI()
        {
            InitializeComponent();
        }

        private void historicButton_Click(object sender, EventArgs e)
        {
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            addCharacter("√");
            enableButtons();
            disableCommaButton();
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            eraseDisplay();
            disableButtons();
            disableCommaButton();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {            
            addCharacter("/");
            disableCommaButton();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            addCharacter("7");
            enableButtons();
            enableCommaButton();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            addCharacter("8");
            enableButtons();
            enableCommaButton();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            addCharacter("9");
            enableButtons();
            enableCommaButton();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            addCharacter("x");
            disableCommaButton();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            addCharacter("4");
            enableButtons();
            enableCommaButton();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            addCharacter("5");
            enableButtons();
            enableCommaButton();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            addCharacter("6");
            enableButtons();
            enableCommaButton();
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            addCharacter("-");
            enableButtons();
            disableCommaButton();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            addCharacter("1");
            enableButtons();
            enableCommaButton();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            addCharacter("2");
            enableButtons();
            enableCommaButton();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            addCharacter("3");
            enableButtons();
            enableCommaButton();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            addCharacter("+");
            enableButtons();
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            addCharacter("%");
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            addCharacter("0");
            enableButtons();
            enableCommaButton();
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            addCharacter(",");
            disableCommaButton();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {

        }

        private void addCharacter(string character)
        {
            displayTextBox.Text += character;
        }

        private void eraseDisplay()
        {
            displayTextBox.Text = "";
        }

        private void enableButtons()
        {
            equalButton.Enabled = true;
            eraseButton.Enabled = true;
            divisionButton.Enabled = true;  
            multiplicationButton.Enabled = true;
            percentageButton.Enabled = true;
        }

        private void disableButtons()
        {
            equalButton.Enabled = false;
            equalButton.Enabled = false;
            divisionButton.Enabled = false;
            multiplicationButton.Enabled = false;
            percentageButton.Enabled = false;
        }

        private void disableCommaButton()
        {
            commaButton.Enabled = false;
        }
        
        private void enableCommaButton()
        {
            commaButton.Enabled = true;
        }
    }
}
