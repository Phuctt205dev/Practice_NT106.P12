namespace Bai01
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
            txtB = new TextBox();
            txtC = new TextBox();
            TxtA = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            txtResult = new TextBox();
            txtResult1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Số Thứ Nhất ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 38);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Thứ Hai ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 38);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Thứ Ba ";
            // 
            // txtB
            // 
            txtB.Location = new Point(113, 35);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            txtB.TextChanged += textBox1_TextChanged;
            // 
            // txtC
            // 
            txtC.Location = new Point(573, 35);
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 27);
            txtC.TabIndex = 4;
            txtC.TextChanged += txtC_TextChanged;
            // 
            // TxtA
            // 
            TxtA.Location = new Point(346, 35);
            TxtA.Name = "TxtA";
            TxtA.Size = new Size(125, 27);
            TxtA.TabIndex = 5;
            TxtA.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(29, 112);
            button1.Name = "button1";
            button1.Size = new Size(78, 45);
            button1.TabIndex = 6;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(262, 112);
            button2.Name = "button2";
            button2.Size = new Size(78, 45);
            button2.TabIndex = 7;
            button2.Text = "Xóa ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(489, 112);
            button3.Name = "button3";
            button3.Size = new Size(78, 45);
            button3.TabIndex = 8;
            button3.Text = "Thoát ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 214);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 9;
            label4.Text = "Số Lớn Nhất ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 214);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Số Nhỏ Nhất ";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(129, 211);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 11;
            // 
            // txtResult1
            // 
            txtResult1.Location = new Point(450, 211);
            txtResult1.Name = "txtResult1";
            txtResult1.Size = new Size(125, 27);
            txtResult1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 304);
            Controls.Add(txtResult1);
            Controls.Add(txtResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtA);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Số Lớn Nhất,Nhỏ Nhất ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox TxtA;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox txtResult;
        private TextBox txtResult1;
    }
}
