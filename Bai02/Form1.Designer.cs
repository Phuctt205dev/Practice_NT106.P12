namespace Bai02
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
            txtA = new TextBox();
            txtB = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 55);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập B ";
            // 
            // txtA
            // 
            txtA.Location = new Point(81, 52);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 2;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(372, 52);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            txtB.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 170);
            button1.Name = "button1";
            button1.Size = new Size(153, 44);
            button1.TabIndex = 5;
            button1.Text = "Tính các giá trị ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(234, 170);
            button2.Name = "button2";
            button2.Size = new Size(94, 44);
            button2.TabIndex = 6;
            button2.Text = "Xóa ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(400, 170);
            button3.Name = "button3";
            button3.Size = new Size(97, 44);
            button3.TabIndex = 7;
            button3.Text = "Thoát ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 73);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "KẾT QUẢ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 330);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tính Giá Trị";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtB;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
    }
}
