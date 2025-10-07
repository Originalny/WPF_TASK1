namespace WPF_KT1
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
            tlp = new TableLayoutPanel();
            btnResult = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnSign = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSubtract = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDivide = new Button();
            btnBack = new Button();
            btnC = new Button();
            txtDisplay = new TextBox();
            btnCE = new Button();
            tlp.SuspendLayout();
            SuspendLayout();
            // 
            // tlp
            // 
            tlp.ColumnCount = 4;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp.Controls.Add(btnResult, 3, 5);
            tlp.Controls.Add(btnDot, 2, 5);
            tlp.Controls.Add(btn0, 1, 5);
            tlp.Controls.Add(btnSign, 0, 5);
            tlp.Controls.Add(btnAdd, 3, 4);
            tlp.Controls.Add(btn3, 2, 4);
            tlp.Controls.Add(btn2, 1, 4);
            tlp.Controls.Add(btn1, 0, 4);
            tlp.Controls.Add(btnSubtract, 3, 3);
            tlp.Controls.Add(btn6, 2, 3);
            tlp.Controls.Add(btn5, 1, 3);
            tlp.Controls.Add(btn4, 0, 3);
            tlp.Controls.Add(btnMultiply, 3, 2);
            tlp.Controls.Add(btn9, 2, 2);
            tlp.Controls.Add(btn8, 1, 2);
            tlp.Controls.Add(btn7, 0, 2);
            tlp.Controls.Add(btnDivide, 3, 1);
            tlp.Controls.Add(btnBack, 2, 1);
            tlp.Controls.Add(btnC, 1, 1);
            tlp.Controls.Add(txtDisplay, 0, 0);
            tlp.Controls.Add(btnCE, 0, 1);
            tlp.Dock = DockStyle.Fill;
            tlp.ForeColor = Color.FromArgb(0, 0, 0, 6);
            tlp.Location = new Point(0, 0);
            tlp.Name = "tlp";
            tlp.RowCount = 6;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlp.Size = new Size(1486, 960);
            tlp.TabIndex = 0;
            // 
            // btnResult
            // 
            btnResult.Dock = DockStyle.Fill;
            btnResult.ForeColor = Color.Black;
            btnResult.Location = new Point(1117, 804);
            btnResult.Margin = new Padding(4);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(365, 152);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += Result_Click;
            // 
            // btnDot
            // 
            btnDot.Dock = DockStyle.Fill;
            btnDot.ForeColor = Color.Black;
            btnDot.Location = new Point(746, 804);
            btnDot.Margin = new Padding(4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(363, 152);
            btnDot.TabIndex = 19;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Dot_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(375, 804);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(363, 152);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Digit_Click;
            // 
            // btnSign
            // 
            btnSign.Dock = DockStyle.Fill;
            btnSign.ForeColor = Color.Black;
            btnSign.Location = new Point(4, 804);
            btnSign.Margin = new Padding(4);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(363, 152);
            btnSign.TabIndex = 17;
            btnSign.Text = "±";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += Sign_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(1117, 644);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(365, 152);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operation_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(746, 644);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(363, 152);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Digit_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(375, 644);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(363, 152);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Digit_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(4, 644);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(363, 152);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Digit_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.ForeColor = Color.Black;
            btnSubtract.Location = new Point(1117, 484);
            btnSubtract.Margin = new Padding(4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(365, 152);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += Operation_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(746, 484);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(363, 152);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Digit_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(375, 484);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(363, 152);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Digit_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(4, 484);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(363, 152);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Digit_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.ForeColor = Color.Black;
            btnMultiply.Location = new Point(1117, 324);
            btnMultiply.Margin = new Padding(4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(365, 152);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Operation_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(746, 324);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(363, 152);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Digit_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(375, 324);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(363, 152);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Digit_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(4, 324);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(363, 152);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Digit_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.ForeColor = Color.Black;
            btnDivide.Location = new Point(1117, 164);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(365, 152);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operation_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(746, 164);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(363, 152);
            btnBack.TabIndex = 3;
            btnBack.Text = "⌫";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += Backspace_Click;
            // 
            // btnC
            // 
            btnC.Dock = DockStyle.Fill;
            btnC.ForeColor = Color.Black;
            btnC.Location = new Point(375, 164);
            btnC.Margin = new Padding(4);
            btnC.Name = "btnC";
            btnC.Size = new Size(363, 152);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += Clear_Click;
            // 
            // txtDisplay
            // 
            tlp.SetColumnSpan(txtDisplay, 4);
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Font = new Font("Segoe UI", 83F);
            txtDisplay.Location = new Point(3, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(1480, 155);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            btnCE.Dock = DockStyle.Fill;
            btnCE.ForeColor = Color.Black;
            btnCE.Location = new Point(4, 164);
            btnCE.Margin = new Padding(4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(363, 152);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += ClearEverything_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1486, 960);
            Controls.Add(tlp);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.GhostWhite;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            tlp.ResumeLayout(false);
            tlp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp;
        private TextBox txtDisplay;
        private Button btnResult;
        private Button btnDot;
        private Button btn0;
        private Button btnSign;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSubtract;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDivide;
        private Button btnBack;
        private Button btnC;
        private Button btnCE;
    }
}
