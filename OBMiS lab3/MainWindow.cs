using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBMiS_lab3
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length > 0)
            {
                try
                {
                    textBoxOutput.Text = CountingHandler.Convert(textBoxInput.Text, (int)numericUpDownInput.Value, (int)numericUpDownOutput.Value);
                    if ((int)numericUpDownOutput.Value == 2)
                    {
                        textBoxPlainCode.Text = CountingHandler.ToPlainCode();
                    }
                    else
                    {
                        textBoxPlainCode.Text = "";
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Неправильный ввод!!!");
                }

            }
        }

        private void doArifmetics(string str)
        {
            string xBin = CountingHandler.Convert(textBoxArifmInput1.Text, (int)numericUpDownArifm.Value, 2);
            string yBin = CountingHandler.Convert(textBoxArifmInput2.Text, (int)numericUpDownArifm.Value, 2);
            switch (str)
            {
                case "+":
                    textBoxArifmOutput.Text = CountingHandler.Add(textBoxArifmInput1.Text, textBoxArifmInput2.Text, (int)numericUpDownArifm.Value);
                    textBoxArifmPCOutput.Text = CountingHandler.BinAdd(xBin, yBin);
                    break;
                case "-":
                    textBoxArifmOutput.Text = CountingHandler.Sub(textBoxArifmInput1.Text, textBoxArifmInput2.Text, (int)numericUpDownArifm.Value);
                    textBoxArifmPCOutput.Text = CountingHandler.BinSub(xBin, yBin);
                    break;
                case "*":
                    textBoxArifmOutput.Text = CountingHandler.Mult(textBoxArifmInput1.Text, textBoxArifmInput2.Text, (int)numericUpDownArifm.Value);
                    textBoxArifmPCOutput.Text = CountingHandler.BinMult(xBin, yBin);

                    break;
                case "/":
                    try
                    {
                        textBoxArifmOutput.Text = CountingHandler.Div(textBoxArifmInput1.Text, textBoxArifmInput2.Text, (int)numericUpDownArifm.Value);
                        textBoxArifmPCOutput.Text = CountingHandler.BinDiv(xBin, yBin);
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show("Делить на ноль нельзя!");
                    }

                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            doArifmetics(buttonAdd.Text);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            doArifmetics(buttonSub.Text);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            doArifmetics(buttonMult.Text);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            doArifmetics(buttonDiv.Text);
        }
    }
}
