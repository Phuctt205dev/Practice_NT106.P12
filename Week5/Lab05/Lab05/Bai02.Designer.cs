namespace Lab05
{
    partial class Bai02
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonIMAP = new System.Windows.Forms.Button();
            this.listViewMess = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPop3 = new System.Windows.Forms.Button();
            this.labelRecent = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotal_2 = new System.Windows.Forms.Label();
            this.labelRecent_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(99, 31);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(383, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(154, 89);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(328, 22);
            this.textBoxPass.TabIndex = 3;
            // 
            // buttonIMAP
            // 
            this.buttonIMAP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIMAP.Location = new System.Drawing.Point(505, 31);
            this.buttonIMAP.Name = "buttonIMAP";
            this.buttonIMAP.Size = new System.Drawing.Size(125, 80);
            this.buttonIMAP.TabIndex = 4;
            this.buttonIMAP.Text = "IMAP";
            this.buttonIMAP.UseVisualStyleBackColor = true;
            this.buttonIMAP.Click += new System.EventHandler(this.buttonIMAP_Click);
            // 
            // listViewMess
            // 
            this.listViewMess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.From,
            this.Time});
            this.listViewMess.HideSelection = false;
            this.listViewMess.Location = new System.Drawing.Point(19, 190);
            this.listViewMess.Name = "listViewMess";
            this.listViewMess.Size = new System.Drawing.Size(759, 248);
            this.listViewMess.TabIndex = 5;
            this.listViewMess.UseCompatibleStateImageBehavior = false;
            // 
            // buttonPop3
            // 
            this.buttonPop3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPop3.Location = new System.Drawing.Point(664, 31);
            this.buttonPop3.Name = "buttonPop3";
            this.buttonPop3.Size = new System.Drawing.Size(114, 80);
            this.buttonPop3.TabIndex = 6;
            this.buttonPop3.Text = "POP3";
            this.buttonPop3.UseVisualStyleBackColor = true;
            this.buttonPop3.Click += new System.EventHandler(this.buttonPop3_Click);
            // 
            // labelRecent
            // 
            this.labelRecent.AutoSize = true;
            this.labelRecent.Location = new System.Drawing.Point(16, 152);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(50, 16);
            this.labelRecent.TabIndex = 7;
            this.labelRecent.Text = "Recent";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(427, 152);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(38, 16);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            // 
            // labelTotal_2
            // 
            this.labelTotal_2.AutoSize = true;
            this.labelTotal_2.Location = new System.Drawing.Point(471, 152);
            this.labelTotal_2.Name = "labelTotal_2";
            this.labelTotal_2.Size = new System.Drawing.Size(0, 16);
            this.labelTotal_2.TabIndex = 9;
            // 
            // labelRecent_2
            // 
            this.labelRecent_2.AutoSize = true;
            this.labelRecent_2.Location = new System.Drawing.Point(72, 152);
            this.labelRecent_2.Name = "labelRecent_2";
            this.labelRecent_2.Size = new System.Drawing.Size(0, 16);
            this.labelRecent_2.TabIndex = 10;
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRecent_2);
            this.Controls.Add(this.labelTotal_2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelRecent);
            this.Controls.Add(this.buttonPop3);
            this.Controls.Add(this.listViewMess);
            this.Controls.Add(this.buttonIMAP);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai02";
            this.Text = "IMAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonIMAP;
        private System.Windows.Forms.ListView listViewMess;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button buttonPop3;
        private System.Windows.Forms.Label labelRecent;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotal_2;
        private System.Windows.Forms.Label labelRecent_2;
    }
}