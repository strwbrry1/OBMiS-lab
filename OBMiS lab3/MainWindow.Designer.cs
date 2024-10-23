namespace OBMiS_lab3
{
    partial class MainWindow
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
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDownInput = new NumericUpDown();
            numericUpDownOutput = new NumericUpDown();
            buttonStart = new Button();
            label3 = new Label();
            textBoxPlainCode = new TextBox();
            numericUpDownArifm = new NumericUpDown();
            label4 = new Label();
            textBoxArifmInput1 = new TextBox();
            textBoxArifmInput2 = new TextBox();
            textBoxArifmOutput = new TextBox();
            label5 = new Label();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMult = new Button();
            buttonDiv = new Button();
            textBoxArifmPCOutput = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArifm).BeginInit();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 74);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(177, 27);
            textBoxInput.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxOutput.Location = new Point(274, 74);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(177, 27);
            textBoxOutput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Ввод";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(274, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Вывод";
            // 
            // numericUpDownInput
            // 
            numericUpDownInput.Location = new Point(12, 41);
            numericUpDownInput.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownInput.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownInput.Name = "numericUpDownInput";
            numericUpDownInput.Size = new Size(69, 27);
            numericUpDownInput.TabIndex = 4;
            numericUpDownInput.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numericUpDownOutput
            // 
            numericUpDownOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownOutput.Location = new Point(274, 41);
            numericUpDownOutput.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownOutput.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownOutput.Name = "numericUpDownOutput";
            numericUpDownOutput.Size = new Size(69, 27);
            numericUpDownOutput.TabIndex = 5;
            numericUpDownOutput.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 127);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(120, 29);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Перевести";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(239, 132);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 7;
            label3.Text = "ПК";
            // 
            // textBoxPlainCode
            // 
            textBoxPlainCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPlainCode.Location = new Point(274, 129);
            textBoxPlainCode.Name = "textBoxPlainCode";
            textBoxPlainCode.ReadOnly = true;
            textBoxPlainCode.Size = new Size(177, 27);
            textBoxPlainCode.TabIndex = 8;
            // 
            // numericUpDownArifm
            // 
            numericUpDownArifm.Location = new Point(12, 231);
            numericUpDownArifm.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownArifm.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownArifm.Name = "numericUpDownArifm";
            numericUpDownArifm.Size = new Size(69, 27);
            numericUpDownArifm.TabIndex = 9;
            numericUpDownArifm.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 10;
            label4.Text = "Ввод для арифметики";
            // 
            // textBoxArifmInput1
            // 
            textBoxArifmInput1.Location = new Point(12, 264);
            textBoxArifmInput1.Name = "textBoxArifmInput1";
            textBoxArifmInput1.Size = new Size(177, 27);
            textBoxArifmInput1.TabIndex = 11;
            // 
            // textBoxArifmInput2
            // 
            textBoxArifmInput2.Location = new Point(12, 332);
            textBoxArifmInput2.Name = "textBoxArifmInput2";
            textBoxArifmInput2.Size = new Size(177, 27);
            textBoxArifmInput2.TabIndex = 12;
            // 
            // textBoxArifmOutput
            // 
            textBoxArifmOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxArifmOutput.Location = new Point(12, 385);
            textBoxArifmOutput.Name = "textBoxArifmOutput";
            textBoxArifmOutput.ReadOnly = true;
            textBoxArifmOutput.Size = new Size(177, 27);
            textBoxArifmOutput.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 362);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 14;
            label5.Text = "=======";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 297);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(30, 29);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(51, 297);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(30, 29);
            buttonSub.TabIndex = 16;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(87, 297);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(30, 29);
            buttonMult.TabIndex = 17;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(123, 297);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(30, 29);
            buttonDiv.TabIndex = 18;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // textBoxArifmPCOutput
            // 
            textBoxArifmPCOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxArifmPCOutput.Location = new Point(274, 385);
            textBoxArifmPCOutput.Name = "textBoxArifmPCOutput";
            textBoxArifmPCOutput.ReadOnly = true;
            textBoxArifmPCOutput.Size = new Size(177, 27);
            textBoxArifmPCOutput.TabIndex = 20;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(274, 362);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 19;
            label6.Text = "Двоичный результат";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(textBoxArifmPCOutput);
            Controls.Add(label6);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMult);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(label5);
            Controls.Add(textBoxArifmOutput);
            Controls.Add(textBoxArifmInput2);
            Controls.Add(textBoxArifmInput1);
            Controls.Add(label4);
            Controls.Add(numericUpDownArifm);
            Controls.Add(textBoxPlainCode);
            Controls.Add(label3);
            Controls.Add(buttonStart);
            Controls.Add(numericUpDownOutput);
            Controls.Add(numericUpDownInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Name = "MainWindow";
            Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArifm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownInput;
        private NumericUpDown numericUpDownOutput;
        private Button buttonStart;
        private Label label3;
        private TextBox textBoxPlainCode;
        private NumericUpDown numericUpDownArifm;
        private Label label4;
        private TextBox textBoxArifmInput1;
        private TextBox textBoxArifmInput2;
        private TextBox textBoxArifmOutput;
        private Label label5;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMult;
        private Button buttonDiv;
        private TextBox textBoxArifmPCOutput;
        private Label label6;
    }
}