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
            ((System.ComponentModel.ISupportInitialize)numericUpDownInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOutput).BeginInit();
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
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
    }
}