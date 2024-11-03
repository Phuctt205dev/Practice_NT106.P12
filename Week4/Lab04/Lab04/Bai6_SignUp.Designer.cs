namespace Lab04
{
    partial class Bai6_SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckGirl = new System.Windows.Forms.CheckBox();
            this.ckBoy = new System.Windows.Forms.CheckBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.txtUN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(98, 52);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(332, 22);
            this.txtPW.TabIndex = 3;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(98, 18);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(332, 22);
            this.txtUN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckGirl);
            this.groupBox2.Controls.Add(this.ckBoy);
            this.groupBox2.Controls.Add(this.cbLang);
            this.groupBox2.Controls.Add(this.dtBD);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPN);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 253);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Information";
            // 
            // ckGirl
            // 
            this.ckGirl.AutoSize = true;
            this.ckGirl.Location = new System.Drawing.Point(293, 212);
            this.ckGirl.Name = "ckGirl";
            this.ckGirl.Size = new System.Drawing.Size(75, 20);
            this.ckGirl.TabIndex = 14;
            this.ckGirl.Text = "Female";
            this.ckGirl.UseVisualStyleBackColor = true;
            this.ckGirl.CheckedChanged += new System.EventHandler(this.ckGirl_CheckedChanged);
            // 
            // ckBoy
            // 
            this.ckBoy.AutoSize = true;
            this.ckBoy.Location = new System.Drawing.Point(130, 212);
            this.ckBoy.Name = "ckBoy";
            this.ckBoy.Size = new System.Drawing.Size(59, 20);
            this.ckBoy.TabIndex = 13;
            this.ckBoy.Text = "Male";
            this.ckBoy.UseVisualStyleBackColor = true;
            this.ckBoy.CheckedChanged += new System.EventHandler(this.ckBoy_CheckedChanged);
            // 
            // cbLang
            // 
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Items.AddRange(new object[] {
            "Vi",
            "Eng",
            "Ja",
            "Ru"});
            this.cbLang.Location = new System.Drawing.Point(130, 178);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(200, 24);
            this.cbLang.TabIndex = 12;
            this.cbLang.Text = "Languages";
            // 
            // dtBD
            // 
            this.dtBD.Location = new System.Drawing.Point(130, 146);
            this.dtBD.Name = "dtBD";
            this.dtBD.Size = new System.Drawing.Size(200, 22);
            this.dtBD.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Sex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Language";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Birthday";
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(130, 114);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(300, 22);
            this.txtPN.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(130, 82);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(300, 22);
            this.txtLN.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lastname";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(130, 50);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(300, 22);
            this.txtFN.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Firstname";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(130, 18);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(300, 22);
            this.txtMail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(377, 415);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(296, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Bai6_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bai6_SignUp";
            this.Text = "Bai6_SignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckGirl;
        private System.Windows.Forms.CheckBox ckBoy;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.DateTimePicker dtBD;
    }
}