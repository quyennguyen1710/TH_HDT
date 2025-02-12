namespace Bai5._4
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
            label1 = new Label();
            txtquangduong = new TextBox();
            btn7cho = new RadioButton();
            groupBox1 = new GroupBox();
            btn4cho = new RadioButton();
            cbgiamgia = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            txtthanhtoan = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 67);
            label1.Name = "label1";
            label1.Size = new Size(296, 36);
            label1.TabIndex = 0;
            label1.Text = "Quãng đường đi (km):";
            // 
            // txtquangduong
            // 
            txtquangduong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtquangduong.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtquangduong.Location = new Point(525, 67);
            txtquangduong.Multiline = true;
            txtquangduong.Name = "txtquangduong";
            txtquangduong.Size = new Size(203, 41);
            txtquangduong.TabIndex = 1;
            txtquangduong.TextChanged += textBox1_TextChanged;
            // 
            // btn7cho
            // 
            btn7cho.AutoSize = true;
            btn7cho.Location = new Point(23, 65);
            btn7cho.Name = "btn7cho";
            btn7cho.Size = new Size(101, 37);
            btn7cho.TabIndex = 2;
            btn7cho.TabStop = true;
            btn7cho.Text = "7 chỗ";
            btn7cho.UseVisualStyleBackColor = true;
            btn7cho.CheckedChanged += btn7cho_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn4cho);
            groupBox1.Controls.Add(btn7cho);
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(78, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 119);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại xe";
            // 
            // btn4cho
            // 
            btn4cho.AutoSize = true;
            btn4cho.Location = new Point(227, 65);
            btn4cho.Name = "btn4cho";
            btn4cho.Size = new Size(101, 37);
            btn4cho.TabIndex = 3;
            btn4cho.TabStop = true;
            btn4cho.Text = "4 chỗ";
            btn4cho.UseVisualStyleBackColor = true;
            btn4cho.CheckedChanged += btn4cho_CheckedChanged;
            // 
            // cbgiamgia
            // 
            cbgiamgia.AutoSize = true;
            cbgiamgia.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbgiamgia.Location = new Point(525, 168);
            cbgiamgia.Name = "cbgiamgia";
            cbgiamgia.Size = new Size(140, 37);
            cbgiamgia.TabIndex = 4;
            cbgiamgia.Text = "Giảm giá";
            cbgiamgia.UseVisualStyleBackColor = true;
            cbgiamgia.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 304);
            label2.Name = "label2";
            label2.Size = new Size(341, 36);
            label2.TabIndex = 5;
            label2.Text = "Số tiền thanh toán (VNĐ)";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(543, 365);
            button1.Name = "button1";
            button1.Size = new Size(163, 42);
            button1.TabIndex = 6;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtthanhtoan
            // 
            txtthanhtoan.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtthanhtoan.Location = new Point(101, 362);
            txtthanhtoan.Multiline = true;
            txtthanhtoan.Name = "txtthanhtoan";
            txtthanhtoan.ReadOnly = true;
            txtthanhtoan.Size = new Size(339, 45);
            txtthanhtoan.TabIndex = 7;
            txtthanhtoan.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 9);
            label3.Name = "label3";
            label3.Size = new Size(113, 33);
            label3.TabIndex = 8;
            label3.Text = "Bảng giá";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtthanhtoan);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cbgiamgia);
            Controls.Add(groupBox1);
            Controls.Add(txtquangduong);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtquangduong;
        private RadioButton btn7cho;
        private GroupBox groupBox1;
        private RadioButton btn4cho;
        private CheckBox cbgiamgia;
        private Label label2;
        private Button button1;
        private TextBox txtthanhtoan;
        private Label label3;
    }
}
