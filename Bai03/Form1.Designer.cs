namespace Bai03
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
            txt1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txt2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 198);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết Quả";
            // 
            // txt1
            // 
            txt1.Location = new Point(160, 35);
            txt1.Name = "txt1";
            txt1.Size = new Size(276, 27);
            txt1.TabIndex = 2;
            txt1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(57, 98);
            button1.Name = "button1";
            button1.Size = new Size(97, 60);
            button1.TabIndex = 3;
            button1.Text = "Đọc";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(234, 98);
            button2.Name = "button2";
            button2.Size = new Size(94, 60);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Location = new Point(417, 98);
            button3.Name = "button3";
            button3.Size = new Size(94, 60);
            button3.TabIndex = 5;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt2
            // 
            txt2.Location = new Point(102, 195);
            txt2.Multiline = true;
            txt2.Name = "txt2";
            txt2.Size = new Size(377, 35);
            txt2.TabIndex = 6;
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(553, 313);
            Controls.Add(txt2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đọc Số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txt2;
    }
}
