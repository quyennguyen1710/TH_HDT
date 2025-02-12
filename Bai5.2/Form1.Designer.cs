namespace Bai5._2
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
            label2 = new Label();
            label3 = new Label();
            txtnhapa = new TextBox();
            txtnhapb = new TextBox();
            txtnhapc = new TextBox();
            btngiai = new Button();
            btnthoat = new Button();
            txtxuat = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 84);
            label1.Name = "label1";
            label1.Size = new Size(159, 33);
            label1.TabIndex = 0;
            label1.Text = "Nhập hệ số a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 167);
            label2.Name = "label2";
            label2.Size = new Size(161, 33);
            label2.TabIndex = 1;
            label2.Text = "Nhập hệ số b";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 255);
            label3.Name = "label3";
            label3.Size = new Size(159, 33);
            label3.TabIndex = 2;
            label3.Text = "Nhập hệ số c";
            // 
            // txtnhapa
            // 
            txtnhapa.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnhapa.Location = new Point(200, 84);
            txtnhapa.Name = "txtnhapa";
            txtnhapa.Size = new Size(150, 40);
            txtnhapa.TabIndex = 3;
            // 
            // txtnhapb
            // 
            txtnhapb.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnhapb.Location = new Point(200, 160);
            txtnhapb.Name = "txtnhapb";
            txtnhapb.Size = new Size(150, 40);
            txtnhapb.TabIndex = 4;
            // 
            // txtnhapc
            // 
            txtnhapc.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnhapc.Location = new Point(200, 248);
            txtnhapc.Name = "txtnhapc";
            txtnhapc.Size = new Size(150, 40);
            txtnhapc.TabIndex = 5;
            // 
            // btngiai
            // 
            btngiai.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btngiai.Location = new Point(23, 324);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(182, 64);
            btngiai.TabIndex = 6;
            btngiai.Text = "Giải";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(249, 324);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(157, 64);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txtxuat
            // 
            txtxuat.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtxuat.Location = new Point(424, 167);
            txtxuat.Multiline = true;
            txtxuat.Name = "txtxuat";
            txtxuat.ReadOnly = true;
            txtxuat.Size = new Size(364, 221);
            txtxuat.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(424, 91);
            label4.Name = "label4";
            label4.Size = new Size(307, 33);
            label4.TabIndex = 9;
            label4.Text = "Nghiệm của phương trình:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtxuat);
            Controls.Add(btnthoat);
            Controls.Add(btngiai);
            Controls.Add(txtnhapc);
            Controls.Add(txtnhapb);
            Controls.Add(txtnhapa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnhapa;
        private TextBox txtnhapb;
        private TextBox txtnhapc;
        private Button btngiai;
        private Button btnthoat;
        private TextBox txtxuat;
        private Label label4;
    }
}
