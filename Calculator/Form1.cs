using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Calculator : Form {
        int firstNumber = 0;
        int secondNumber = 0;
        int final = 0;
        char symbol = '+';
        public Calculator() {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e) {
            if (result.Text == "0")
                result.Text = oneButton.Text;
            else
                result.Text += oneButton.Text;
        }

        private void twoButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text = twoButton.Text;
            else result.Text += twoButton.Text;
        }

        private void threeButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text = threeButton.Text;
            else
                result.Text += threeButton.Text;
        }

        private void fourButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text = fourButton.Text;
            else
                result.Text += fourButton.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text = fiveButton.Text;
            else
                result.Text += fiveButton.Text;
        }

        private void sixButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text += sixButton.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text = sevenButton.Text;
            else
                result.Text += sevenButton.Text;
        }

        private void eightButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
                result.Text = eightButton.Text;
            else
                result.Text += eightButton.Text;
        }

        private void nineButton_Click(object sender, EventArgs e) {
            if(result.Text == "0")
            result.Text = nineButton.Text;
            else
                result.Text += nineButton.Text;
        }

        private void zeroButton_Click(object sender, EventArgs e) {
            if(result.Text != "0")
                result.Text += zeroButton.Text;
        }

        private void plusButton_Click(object sender, EventArgs e) {
            Int32.TryParse(result.Text, out firstNumber);
            symbol = '+';
            result.Text = "0";
        }

        private void minusButton_Click(object sender, EventArgs e) {
            Int32.TryParse(result.Text, out firstNumber);
            symbol = '-';
            result.Text = "0";
        }

        private void multiButton_Click(object sender, EventArgs e) {
            Int32.TryParse(result.Text, out firstNumber);
            symbol = '*';
            result.Text = "0";
        }

        private void divButton_Click(object sender, EventArgs e) {
            Int32.TryParse(result.Text, out firstNumber);
            symbol = '/';
            result.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e) {
            Int32.TryParse(result.Text, out secondNumber);
            switch (symbol) {
                default: break;
                case '+':
                    final = firstNumber + secondNumber;
                    result.Text = final.ToString();
                    firstNumber = 0 ; secondNumber = 0; final = 0;
                    break;
                case '-': 
                    final = firstNumber - secondNumber;
                    result.Text = final.ToString();
                    firstNumber = 0; secondNumber = 0; final= 0;
                    break;
                case '*': 
                    final= firstNumber * secondNumber;
                    result.Text = final.ToString();
                    firstNumber = 0 ; secondNumber= 0; final= 0;
                    break;
                case '/': 
                    final = firstNumber / secondNumber;
                    result.Text = final.ToString();
                    firstNumber = 0 ;secondNumber = 0; final= 0;
                    break;
            }
        }
    }
}
