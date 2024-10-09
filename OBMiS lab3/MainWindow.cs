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
                } catch (ArgumentException ex) 
                {
                    MessageBox.Show("Неправильный ввод!!!");
                }
                
            }
        }
    }
}
