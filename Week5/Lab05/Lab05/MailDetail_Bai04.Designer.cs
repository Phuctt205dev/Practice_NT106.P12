namespace Lab05
{
    partial class MailDetail_Bai04
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
            this.lbSub = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCont = new System.Windows.Forms.Label();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.rtbMailContent = new System.Windows.Forms.RichTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSub
            // 
            this.lbSub.AutoSize = true;
            this.lbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSub.Location = new System.Drawing.Point(11, 9);
            this.lbSub.Name = "lbSub";
            this.lbSub.Size = new System.Drawing.Size(84, 20);
            this.lbSub.TabIndex = 0;
            this.lbSub.Text = "Subject: ";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFrom.Location = new System.Drawing.Point(12, 42);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(64, 20);
            this.lbFrom.TabIndex = 1;
            this.lbFrom.Text = "From: ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDate.Location = new System.Drawing.Point(11, 79);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(61, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date: ";
            // 
            // lbCont
            // 
            this.lbCont.AutoSize = true;
            this.lbCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCont.Location = new System.Drawing.Point(12, 123);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(86, 20);
            this.lbCont.TabIndex = 3;
            this.lbCont.Text = "Content: ";
            // 
            // tbSub
            // 
            this.tbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSub.Location = new System.Drawing.Point(101, 7);
            this.tbSub.Name = "tbSub";
            this.tbSub.ReadOnly = true;
            this.tbSub.Size = new System.Drawing.Size(511, 24);
            this.tbSub.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbFrom.Location = new System.Drawing.Point(101, 40);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.ReadOnly = true;
            this.tbFrom.Size = new System.Drawing.Size(511, 24);
            this.tbFrom.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDate.Location = new System.Drawing.Point(101, 77);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(511, 24);
            this.tbDate.TabIndex = 6;
            // 
            // rtbMailContent
            // 
            this.rtbMailContent.Location = new System.Drawing.Point(12, 146);
            this.rtbMailContent.Name = "rtbMailContent";
            this.rtbMailContent.ReadOnly = true;
            this.rtbMailContent.Size = new System.Drawing.Size(424, 283);
            this.rtbMailContent.TabIndex = 7;
            this.rtbMailContent.Text = "";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(442, 146);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(346, 283);
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // MailDetail_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.rtbMailContent);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.lbCont);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbSub);
            this.Name = "MailDetail_Bai04";
            this.Text = "MailDetail_Bai04";
            this.Load += new System.EventHandler(this.MailDetail_Bai04_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSub;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCont;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.RichTextBox rtbMailContent;
        private System.Windows.Forms.PictureBox pbImage;
    }
}