namespace assignment2._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DepositAmount = new TextBox();
            todaysDate = new DateTimePicker();
            maturityDate = new MonthCalendar();
            ReturnAmount = new RichTextBox();
            groupBox1 = new GroupBox();
            simpleInterest = new RadioButton();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Deposit = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            InterestRate = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InterestRate).BeginInit();
            SuspendLayout();
            // 
            // DepositAmount
            // 
            DepositAmount.Location = new Point(12, 47);
            DepositAmount.Name = "DepositAmount";
            DepositAmount.Size = new Size(221, 23);
            DepositAmount.TabIndex = 0;
            DepositAmount.TextChanged += textBox1_TextChanged;
            // 
            // todaysDate
            // 
            todaysDate.Location = new Point(294, 47);
            todaysDate.Name = "todaysDate";
            todaysDate.Size = new Size(200, 23);
            todaysDate.TabIndex = 1;
            todaysDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // maturityDate
            // 
            maturityDate.Location = new Point(294, 113);
            maturityDate.Name = "maturityDate";
            maturityDate.TabIndex = 2;
            maturityDate.DateChanged += monthCalendar1_DateChanged;
            // 
            // ReturnAmount
            // 
            ReturnAmount.Location = new Point(294, 307);
            ReturnAmount.Name = "ReturnAmount";
            ReturnAmount.ReadOnly = true;
            ReturnAmount.Size = new Size(227, 96);
            ReturnAmount.TabIndex = 3;
            ReturnAmount.Text = "";
            ReturnAmount.TextChanged += richTextBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(simpleInterest);
            groupBox1.Location = new Point(12, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // simpleInterest
            // 
            simpleInterest.AutoSize = true;
            simpleInterest.Location = new Point(6, 44);
            simpleInterest.Name = "simpleInterest";
            simpleInterest.Size = new Size(103, 19);
            simpleInterest.TabIndex = 1;
            simpleInterest.TabStop = true;
            simpleInterest.Text = "Simple Interest";
            simpleInterest.UseVisualStyleBackColor = true;
            simpleInterest.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(595, 380);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 5;
            button1.Text = "Show ME the money";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Deposit
            // 
            Deposit.AutoSize = true;
            Deposit.Location = new Point(12, 19);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(94, 15);
            Deposit.TabIndex = 7;
            Deposit.Text = "Deposit Amount";
            Deposit.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 85);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 8;
            label1.Text = "Interest Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 9;
            label2.Text = "Today's Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 85);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 10;
            label3.Text = "Date of Maturity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 284);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 11;
            label4.Text = "MY RETURN";
            // 
            // InterestRate
            // 
            InterestRate.DecimalPlaces = 1;
            InterestRate.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            InterestRate.Location = new Point(18, 113);
            InterestRate.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            InterestRate.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            InterestRate.Name = "InterestRate";
            InterestRate.Size = new Size(128, 23);
            InterestRate.TabIndex = 12;
            InterestRate.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InterestRate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Deposit);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(ReturnAmount);
            Controls.Add(maturityDate);
            Controls.Add(todaysDate);
            Controls.Add(DepositAmount);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InterestRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DepositAmount;
        private DateTimePicker todaysDate;
        private MonthCalendar maturityDate;
        private RichTextBox ReturnAmount;
        private GroupBox groupBox1;
        private RadioButton simpleInterest;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private Label Deposit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown InterestRate;
    }
}
