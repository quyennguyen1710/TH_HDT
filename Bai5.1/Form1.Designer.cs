namespace Bai5._1
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
            txtnhap = new TextBox();
            btnchuvi = new Button();
            btndientich = new Button();
            btnthoat = new Button();
            txtXuat = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 47);
            label1.Name = "label1";
            label1.Size = new Size(450, 45);
            label1.TabIndex = 0;
            label1.Text = "Nhập bán kính hình tròn:";
            // 
            // txtnhap
            // 
            txtnhap.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnhap.Location = new Point(568, 39);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(150, 53);
            txtnhap.TabIndex = 1;
            // 
            // btnchuvi
            // 
            btnchuvi.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnchuvi.Location = new Point(81, 153);
            btnchuvi.Name = "btnchuvi";
            btnchuvi.Size = new Size(183, 67);
            btnchuvi.TabIndex = 2;
            btnchuvi.Text = "Chu vi";
            btnchuvi.UseVisualStyleBackColor = true;
            btnchuvi.Click += btnchuvi_Click;
            // 
            // btndientich
            // 
            btndientich.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndientich.Location = new Point(328, 153);
            btndientich.Name = "btndientich";
            btndientich.Size = new Size(225, 67);
            btndientich.TabIndex = 3;
            btndientich.Text = "Diện tích";
            btndientich.UseVisualStyleBackColor = true;
            btndientich.Click += btndientich_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(607, 153);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(148, 67);
            btnthoat.TabIndex = 4;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txtXuat
            // 
            txtXuat.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXuat.Location = new Point(81, 266);
            txtXuat.Multiline = true;
            txtXuat.Name = "txtXuat";
            txtXuat.ReadOnly = true;
            txtXuat.Size = new Size(674, 150);
            txtXuat.TabIndex = 5;
            txtXuat.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtXuat);
            Controls.Add(btnthoat);
            Controls.Add(btndientich);
            Controls.Add(btnchuvi);
            Controls.Add(txtnhap);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnhap;
        private Button btnchuvi;
        private Button btndientich;
        private Button btnthoat;
        private TextBox txtXuat;
    }
}
