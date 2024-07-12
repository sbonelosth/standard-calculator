namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnEval = new Button();
            btnPt = new Button();
            btn0 = new Button();
            btnNeg = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDiv = new Button();
            btnMod = new Button();
            btnDel = new Button();
            btnClear = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtCurrentOperand = new TextBox();
            txtPreviousOperand = new TextBox();
            lblOperator = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            label2 = new Label();
            txtHistory = new RichTextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnClose = new Label();
            labelName = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(488, 618);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnEval, 3, 4);
            tableLayoutPanel4.Controls.Add(btnPt, 2, 4);
            tableLayoutPanel4.Controls.Add(btn0, 1, 4);
            tableLayoutPanel4.Controls.Add(btnNeg, 0, 4);
            tableLayoutPanel4.Controls.Add(btnAdd, 3, 3);
            tableLayoutPanel4.Controls.Add(btn3, 2, 3);
            tableLayoutPanel4.Controls.Add(btn2, 1, 3);
            tableLayoutPanel4.Controls.Add(btn1, 0, 3);
            tableLayoutPanel4.Controls.Add(btnSub, 3, 2);
            tableLayoutPanel4.Controls.Add(btn6, 2, 2);
            tableLayoutPanel4.Controls.Add(btn5, 1, 2);
            tableLayoutPanel4.Controls.Add(btn4, 0, 2);
            tableLayoutPanel4.Controls.Add(btnMultiply, 3, 1);
            tableLayoutPanel4.Controls.Add(btn9, 2, 1);
            tableLayoutPanel4.Controls.Add(btn8, 1, 1);
            tableLayoutPanel4.Controls.Add(btn7, 0, 1);
            tableLayoutPanel4.Controls.Add(btnDiv, 3, 0);
            tableLayoutPanel4.Controls.Add(btnMod, 2, 0);
            tableLayoutPanel4.Controls.Add(btnDel, 1, 0);
            tableLayoutPanel4.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 126);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(482, 489);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnEval
            // 
            btnEval.BackColor = Color.Orange;
            btnEval.Dock = DockStyle.Fill;
            btnEval.FlatAppearance.BorderSize = 0;
            btnEval.FlatStyle = FlatStyle.Flat;
            btnEval.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEval.ForeColor = SystemColors.ControlLight;
            btnEval.Location = new Point(363, 391);
            btnEval.Name = "btnEval";
            btnEval.Size = new Size(116, 95);
            btnEval.TabIndex = 19;
            btnEval.Text = "=";
            btnEval.UseVisualStyleBackColor = false;
            btnEval.Click += BtnEval_Click;
            // 
            // btnPt
            // 
            btnPt.BackColor = Color.FromArgb(65, 65, 65);
            btnPt.Dock = DockStyle.Fill;
            btnPt.FlatAppearance.BorderSize = 0;
            btnPt.FlatStyle = FlatStyle.Flat;
            btnPt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnPt.ForeColor = SystemColors.Control;
            btnPt.Location = new Point(243, 391);
            btnPt.Name = "btnPt";
            btnPt.Size = new Size(114, 95);
            btnPt.TabIndex = 18;
            btnPt.Text = ",";
            btnPt.UseVisualStyleBackColor = false;
            btnPt.Click += BtnNum_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(65, 65, 65);
            btn0.Dock = DockStyle.Fill;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.Control;
            btn0.Location = new Point(123, 391);
            btn0.Name = "btn0";
            btn0.Size = new Size(114, 95);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BtnNum_Click;
            // 
            // btnNeg
            // 
            btnNeg.BackColor = Color.FromArgb(65, 65, 65);
            btnNeg.Dock = DockStyle.Fill;
            btnNeg.FlatAppearance.BorderSize = 0;
            btnNeg.FlatStyle = FlatStyle.Flat;
            btnNeg.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnNeg.ForeColor = SystemColors.Control;
            btnNeg.Location = new Point(3, 391);
            btnNeg.Name = "btnNeg";
            btnNeg.Size = new Size(114, 95);
            btnNeg.TabIndex = 16;
            btnNeg.Text = "±";
            btnNeg.UseVisualStyleBackColor = false;
            btnNeg.Click += BtnNum_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(55, 55, 55);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ControlLight;
            btnAdd.Location = new Point(363, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 91);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnOperator_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(65, 65, 65);
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.Control;
            btn3.Location = new Point(243, 294);
            btn3.Name = "btn3";
            btn3.Size = new Size(114, 91);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BtnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(65, 65, 65);
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.Control;
            btn2.Location = new Point(123, 294);
            btn2.Name = "btn2";
            btn2.Size = new Size(114, 91);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BtnNum_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(65, 65, 65);
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(3, 294);
            btn1.Name = "btn1";
            btn1.Size = new Size(114, 91);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BtnNum_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(55, 55, 55);
            btnSub.Dock = DockStyle.Fill;
            btnSub.FlatAppearance.BorderSize = 0;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSub.ForeColor = SystemColors.ControlLight;
            btnSub.Location = new Point(363, 197);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(116, 91);
            btnSub.TabIndex = 11;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += BtnOperator_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(65, 65, 65);
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.Control;
            btn6.Location = new Point(243, 197);
            btn6.Name = "btn6";
            btn6.Size = new Size(114, 91);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BtnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(65, 65, 65);
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.Control;
            btn5.Location = new Point(123, 197);
            btn5.Name = "btn5";
            btn5.Size = new Size(114, 91);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BtnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(65, 65, 65);
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.Control;
            btn4.Location = new Point(3, 197);
            btn4.Name = "btn4";
            btn4.Size = new Size(114, 91);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BtnNum_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(55, 55, 55);
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnMultiply.ForeColor = SystemColors.ControlLight;
            btnMultiply.Location = new Point(363, 100);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(116, 91);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += BtnOperator_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(65, 65, 65);
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.Control;
            btn9.Location = new Point(243, 100);
            btn9.Name = "btn9";
            btn9.Size = new Size(114, 91);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BtnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(65, 65, 65);
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.Control;
            btn8.Location = new Point(123, 100);
            btn8.Name = "btn8";
            btn8.Size = new Size(114, 91);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BtnNum_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(65, 65, 65);
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.Control;
            btn7.Location = new Point(3, 100);
            btn7.Name = "btn7";
            btn7.Size = new Size(114, 91);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BtnNum_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(55, 55, 55);
            btnDiv.Dock = DockStyle.Fill;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDiv.ForeColor = SystemColors.ControlLight;
            btnDiv.Location = new Point(363, 3);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(116, 91);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += BtnOperator_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.FromArgb(55, 55, 55);
            btnMod.Dock = DockStyle.Fill;
            btnMod.FlatAppearance.BorderSize = 0;
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnMod.ForeColor = SystemColors.ControlLight;
            btnMod.Location = new Point(243, 3);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(114, 91);
            btnMod.TabIndex = 2;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            btnMod.Click += BtnOperator_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(55, 55, 55);
            btnDel.Dock = DockStyle.Fill;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 18F);
            btnDel.ForeColor = Color.Coral;
            btnDel.Location = new Point(123, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(114, 91);
            btnDel.TabIndex = 1;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += BtnDel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(55, 55, 55);
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.ForeColor = Color.Coral;
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 91);
            btnClear.TabIndex = 0;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.62656F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3734436F));
            tableLayoutPanel6.Controls.Add(txtCurrentOperand, 0, 1);
            tableLayoutPanel6.Controls.Add(txtPreviousOperand, 0, 0);
            tableLayoutPanel6.Controls.Add(lblOperator, 1, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 41.88034F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 58.11966F));
            tableLayoutPanel6.Size = new Size(482, 117);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // txtCurrentOperand
            // 
            txtCurrentOperand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCurrentOperand.BackColor = Color.Black;
            txtCurrentOperand.BorderStyle = BorderStyle.None;
            tableLayoutPanel6.SetColumnSpan(txtCurrentOperand, 2);
            txtCurrentOperand.Font = new Font("Segoe UI", 22F);
            txtCurrentOperand.ForeColor = SystemColors.ControlLight;
            txtCurrentOperand.Location = new Point(3, 52);
            txtCurrentOperand.Multiline = true;
            txtCurrentOperand.Name = "txtCurrentOperand";
            txtCurrentOperand.ReadOnly = true;
            txtCurrentOperand.Size = new Size(476, 62);
            txtCurrentOperand.TabIndex = 0;
            txtCurrentOperand.Text = "0";
            txtCurrentOperand.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPreviousOperand
            // 
            txtPreviousOperand.BackColor = Color.Black;
            txtPreviousOperand.BorderStyle = BorderStyle.None;
            txtPreviousOperand.Dock = DockStyle.Fill;
            txtPreviousOperand.Font = new Font("Segoe UI", 14F);
            txtPreviousOperand.ForeColor = SystemColors.ControlLight;
            txtPreviousOperand.Location = new Point(3, 3);
            txtPreviousOperand.Multiline = true;
            txtPreviousOperand.Name = "txtPreviousOperand";
            txtPreviousOperand.ReadOnly = true;
            txtPreviousOperand.Size = new Size(426, 43);
            txtPreviousOperand.TabIndex = 1;
            txtPreviousOperand.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.BackColor = Color.Black;
            lblOperator.Dock = DockStyle.Fill;
            lblOperator.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOperator.ForeColor = SystemColors.ControlLight;
            lblOperator.Location = new Point(435, 0);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(44, 49);
            lblOperator.TabIndex = 2;
            lblOperator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtHistory, 0, 1);
            tableLayoutPanel2.Location = new Point(501, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.41424F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.58576F));
            tableLayoutPanel2.Size = new Size(387, 618);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.40157F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5984249F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(381, 46);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(336, 3);
            button1.Name = "button1";
            button1.Size = new Size(42, 40);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnClearHistory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(327, 46);
            label2.TabIndex = 3;
            label2.Text = "History";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.Black;
            txtHistory.BorderStyle = BorderStyle.None;
            txtHistory.Dock = DockStyle.Fill;
            txtHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtHistory.ForeColor = SystemColors.ActiveBorder;
            txtHistory.Location = new Point(9, 55);
            txtHistory.Margin = new Padding(9, 3, 3, 3);
            txtHistory.Name = "txtHistory";
            txtHistory.ReadOnly = true;
            txtHistory.Size = new Size(375, 560);
            txtHistory.TabIndex = 1;
            txtHistory.Text = "";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(btnClose, 0, 0);
            tableLayoutPanel5.Location = new Point(847, -2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(62, 48);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("SimSun", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.Bisque;
            btnClose.Location = new Point(3, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(56, 48);
            btnClose.TabIndex = 2;
            btnClose.Text = "×";
            btnClose.TextAlign = ContentAlignment.MiddleCenter;
            btnClose.Click += BtnClose_Click;
            btnClose.MouseDown += BtnClose_MouseDown;
            btnClose.MouseLeave += BtnClose_MouseLeave;
            btnClose.MouseHover += BtnClose_MouseHover;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelName.ForeColor = SystemColors.ActiveBorder;
            labelName.Location = new Point(13, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(315, 45);
            labelName.TabIndex = 3;
            labelName.Text = "Standard Calculator";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(905, 723);
            Controls.Add(labelName);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEval;
        private Button btnPt;
        private Button btn0;
        private Button btnNeg;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDiv;
        private Button btnMod;
        private Button btnDel;
        private Button btnClear;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtCurrentOperand;
        private TextBox txtPreviousOperand;
        private Label lblOperator;
        private Label btnClose;
        private Button button1;
        private Label label2;
        private RichTextBox txtHistory;
        private Label labelName;
    }
}
