namespace Bai5._5
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
            groupBox1 = new GroupBox();
            rbtnhcn = new RadioButton();
            rbtnhinhtron = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnhcn);
            groupBox1.Controls.Add(rbtnhinhtron);
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(598, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shape";
            groupBox1.Leave += groupBox1_Leave;
            // 
            // rbtnhcn
            // 
            rbtnhcn.AutoSize = true;
            rbtnhcn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnhcn.Location = new Point(31, 76);
            rbtnhcn.Name = "rbtnhcn";
            rbtnhcn.Size = new Size(133, 31);
            rbtnhcn.TabIndex = 1;
            rbtnhcn.TabStop = true;
            rbtnhcn.Text = "Rectangle";
            rbtnhcn.UseVisualStyleBackColor = true;
            // 
            // rbtnhinhtron
            // 
            rbtnhinhtron.AutoSize = true;
            rbtnhinhtron.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnhinhtron.Location = new Point(31, 39);
            rbtnhinhtron.Name = "rbtnhinhtron";
            rbtnhinhtron.Size = new Size(96, 31);
            rbtnhinhtron.TabIndex = 0;
            rbtnhinhtron.TabStop = true;
            rbtnhinhtron.Text = "Elipse";
            rbtnhinhtron.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtnhinhtron;
        private RadioButton rbtnhcn;
    }
}
