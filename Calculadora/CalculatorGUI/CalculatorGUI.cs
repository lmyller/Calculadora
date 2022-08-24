using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Historic;

namespace Calculadora
{
    public partial class CalculatorGUI : Form
    {
        private int _countSymbol;
        private Historic historic;

        public CalculatorGUI()
        {
            InitializeComponent();

            historic = new Historic();
        }

        private void historicButton_Click(object sender, EventArgs e)
        {
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (_countSymbol == 0)
            {
                addCharacter("√");
                enableButtons();
                disableCommaButton();
                IncreaseCountSymbol();
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            eraseDisplay();
            disableButtons();
            disableCommaButton();
            _countSymbol = 0;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (_countSymbol == 0)
            {
                addCharacter("/");
                disableCommaButton();
                IncreaseCountSymbol();
            }
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
            if (_countSymbol == 0)
            {
                addCharacter("x");
                disableCommaButton();
                IncreaseCountSymbol();
            }
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
            if (_countSymbol == 0)
            {
                addCharacter("-");
                enableButtons();
                disableCommaButton();
                IncreaseCountSymbol();  
            }
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
            if (_countSymbol == 0)
            {
                addCharacter("+");
                enableButtons();
                IncreaseCountSymbol();  
            }
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text[displayTextBox.Text.Length - 1] != '%')
            {
                addCharacter("%");
            }
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
            if (displayTextBox.Text[0].Equals('√'))
            {
                SquareRoot();
            }

            if (displayTextBox.Text.Contains('+'))
            {
                Addition();
            }

            if (displayTextBox.Text.Contains('-'))
            {
                Subtraction();
            }
            
            if (displayTextBox.Text.Contains('x'))
            {
                Multiplication();
            }
            
            if (displayTextBox.Text.Contains('/'))
            {
                Division();
            }

            _countSymbol = 0;
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

        private void IncreaseCountSymbol()
        {
            _countSymbol++;
        }

        private void SquareRoot()
        {
            string stringNumber = RemoveSymbolMathOperation(1, displayTextBox.Text.Length);

            historic.Add(displayTextBox.Text);

            displayTextBox.Text = Math.Sqrt(double.Parse(stringNumber)).ToString();
        }

        private void Addition()
        {
            string[] numeros = displayTextBox.Text.Split('+');

            historic.Add(displayTextBox.Text);

            displayTextBox.Text = (double.Parse(numeros[0]) + double.Parse(numeros[1])).ToString();
        }
        private void Subtraction()
        {
            string[] numeros = displayTextBox.Text.Split('-');

            historic.Add(displayTextBox.Text);

            displayTextBox.Text = (double.Parse(numeros[0]) - double.Parse(numeros[1])).ToString();
        }
        
        private void Multiplication()
        {
            string[] numeros = displayTextBox.Text.Split('x');

            historic.Add(displayTextBox.Text);

            displayTextBox.Text = (double.Parse(numeros[0]) * double.Parse(numeros[1])).ToString();
        }
        
        private void Division()
        {
            string[] numeros = displayTextBox.Text.Split('/');

            historic.Add(displayTextBox.Text);

            displayTextBox.Text = (double.Parse(numeros[0]) / double.Parse(numeros[1])).ToString();
        }

        private string RemoveSymbolMathOperation(int begin, int end)
        {
            return displayTextBox.Text.Substring(begin, end - 1);
        }

        private void CalculatorGUI_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0: zeroButton_Click(sender, e); break;
                case Keys.D1: oneButton_Click(sender, e); break;
                case Keys.D2: twoButton_Click(sender, e); break;
                case Keys.D3: threeButton_Click(sender, e); break;
                case Keys.D4: fourButton_Click(sender, e); break;
                case Keys.D5: fiveButton_Click(sender, e); break;
                case Keys.D6: sixButton_Click(sender, e); break;
                case Keys.D7: sevenButton_Click(sender, e); break;
                case Keys.D8: eightButton_Click(sender, e); break;
                case Keys.D9: nineButton_Click(sender, e); break;
                case Keys.X: multiplicationButton_Click(sender, e); break;
                case Keys.Divide: divisionButton_Click(sender, e); break;
                case Keys.Subtract: subtractionButton_Click(sender, e); break;
                case Keys.Add: additionButton_Click(sender, e); break;
                case Keys.C: eraseButton_Click(sender, e); break;
                case Keys.Oemcomma: commaButton_Click(sender, e); break;
                case Keys.Enter: equalButton_Click(sender, e); break;
                case Keys.H: historicButton_Click(sender, e); break;
            }
        }
    }
}
