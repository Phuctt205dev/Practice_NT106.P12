﻿namespace Lab02
{
    partial class Bai01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.readfile = new System.Windows.Forms.Button();
            this.writerbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 277);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // readfile
            // 
            this.readfile.Location = new System.Drawing.Point(12, 316);
            this.readfile.Name = "readfile";
            this.readfile.Size = new System.Drawing.Size(157, 75);
            this.readfile.TabIndex = 1;
            this.readfile.Text = "ĐỌC";
            this.readfile.UseVisualStyleBackColor = true;
            this.readfile.Click += new System.EventHandler(this.readfile_Click_1);
            // 
            // writerbutton
            // 
            this.writerbutton.Location = new System.Drawing.Point(306, 316);
            this.writerbutton.Name = "writerbutton";
            this.writerbutton.Size = new System.Drawing.Size(157, 75);
            this.writerbutton.TabIndex = 2;
            this.writerbutton.Text = "GHI";
            this.writerbutton.UseVisualStyleBackColor = true;
            this.writerbutton.Click += new System.EventHandler(this.writerbutton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.writerbutton);
            this.Controls.Add(this.readfile);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button readfile;
        private System.Windows.Forms.Button writerbutton;
        private System.Windows.Forms.Button button1;
    }
}