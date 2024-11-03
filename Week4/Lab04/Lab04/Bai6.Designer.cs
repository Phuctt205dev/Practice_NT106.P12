namespace Lab04
{
    partial class Bai6
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
            this.cbCurPage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPageS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbAccSta = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnWEat = new System.Windows.Forms.Button();
            this.btnAddF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCurPage
            // 
            this.cbCurPage.FormattingEnabled = true;
            this.cbCurPage.Location = new System.Drawing.Point(615, 390);
            this.cbCurPage.Name = "cbCurPage";
            this.cbCurPage.Size = new System.Drawing.Size(45, 24);
            this.cbCurPage.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Page";
            // 
            // cbPageS
            // 
            this.cbPageS.FormattingEnabled = true;
            this.cbPageS.Location = new System.Drawing.Point(741, 390);
            this.cbPageS.Name = "cbPageS";
            this.cbPageS.Size = new System.Drawing.Size(45, 24);
            this.cbPageS.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Page Size";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbAccSta,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 29);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbAccSta
            // 
            this.lbAccSta.ActiveLinkColor = System.Drawing.Color.Red;
            this.lbAccSta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAccSta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAccSta.Name = "lbAccSta";
            this.lbAccSta.Size = new System.Drawing.Size(143, 23);
            this.lbAccSta.Text = "Unauthenticated";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 21);
            // 
            // btnWEat
            // 
            this.btnWEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWEat.Location = new System.Drawing.Point(436, 5);
            this.btnWEat.Name = "btnWEat";
            this.btnWEat.Size = new System.Drawing.Size(173, 62);
            this.btnWEat.TabIndex = 28;
            this.btnWEat.Text = "Ăn gì giờ?";
            this.btnWEat.UseVisualStyleBackColor = true;
            this.btnWEat.Click += new System.EventHandler(this.btnWEat_Click);
            // 
            // btnAddF
            // 
            this.btnAddF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddF.Location = new System.Drawing.Point(615, 5);
            this.btnAddF.Name = "btnAddF";
            this.btnAddF.Size = new System.Drawing.Size(173, 62);
            this.btnAddF.TabIndex = 27;
            this.btnAddF.Text = "Thêm món ăn";
            this.btnAddF.UseVisualStyleBackColor = true;
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 311);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tôi đóng góp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCurPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPageS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnWEat);
            this.Controls.Add(this.btnAddF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPageS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbAccSta;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnWEat;
        private System.Windows.Forms.Button btnAddF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}