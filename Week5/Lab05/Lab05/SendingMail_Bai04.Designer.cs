namespace Lab05
{
    partial class SendingMail_Bai04
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
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.lbAtta = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.rtbMailContent = new System.Windows.Forms.RichTextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.ckbHTML = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFrom.Location = new System.Drawing.Point(17, 11);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(64, 20);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "From: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(17, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name: ";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTo.Location = new System.Drawing.Point(17, 67);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(42, 20);
            this.lbTo.TabIndex = 2;
            this.lbTo.Text = "To: ";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSubject.Location = new System.Drawing.Point(17, 95);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(84, 20);
            this.lbSubject.TabIndex = 3;
            this.lbSubject.Text = "Subject: ";
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBody.Location = new System.Drawing.Point(17, 139);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(63, 20);
            this.lbBody.TabIndex = 4;
            this.lbBody.Text = "Body: ";
            // 
            // lbAtta
            // 
            this.lbAtta.AutoSize = true;
            this.lbAtta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAtta.Location = new System.Drawing.Point(17, 386);
            this.lbAtta.Name = "lbAtta";
            this.lbAtta.Size = new System.Drawing.Size(116, 20);
            this.lbAtta.TabIndex = 5;
            this.lbAtta.Text = "Attachment: ";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(141, 9);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.ReadOnly = true;
            this.tbFrom.Size = new System.Drawing.Size(575, 22);
            this.tbFrom.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(575, 22);
            this.tbName.TabIndex = 7;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(141, 65);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(575, 22);
            this.tbTo.TabIndex = 8;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(141, 93);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(575, 22);
            this.tbSubject.TabIndex = 9;
            // 
            // rtbMailContent
            // 
            this.rtbMailContent.Location = new System.Drawing.Point(141, 177);
            this.rtbMailContent.Name = "rtbMailContent";
            this.rtbMailContent.Size = new System.Drawing.Size(647, 203);
            this.rtbMailContent.TabIndex = 10;
            this.rtbMailContent.Text = "";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(141, 384);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(517, 22);
            this.tbFilePath.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(664, 386);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(124, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(664, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(124, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ckbHTML
            // 
            this.ckbHTML.AutoSize = true;
            this.ckbHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbHTML.Location = new System.Drawing.Point(141, 138);
            this.ckbHTML.Name = "ckbHTML";
            this.ckbHTML.Size = new System.Drawing.Size(82, 24);
            this.ckbHTML.TabIndex = 14;
            this.ckbHTML.Text = "HTML";
            this.ckbHTML.UseVisualStyleBackColor = true;
            // 
            // SendingMail_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbHTML);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.rtbMailContent);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lbAtta);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbFrom);
            this.Name = "SendingMail_Bai04";
            this.Text = "SendingMail";
            this.Load += new System.EventHandler(this.SendingMail_Bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.Label lbAtta;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.RichTextBox rtbMailContent;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox ckbHTML;
    }
}