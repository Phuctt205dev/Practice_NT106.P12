namespace Lab03
{
    partial class Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04));
            this.lv_Message = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_ListAccount = new System.Windows.Forms.ListView();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Message
            // 
            this.lv_Message.HideSelection = false;
            this.lv_Message.Location = new System.Drawing.Point(12, 92);
            this.lv_Message.Name = "lv_Message";
            this.lv_Message.Size = new System.Drawing.Size(364, 300);
            this.lv_Message.TabIndex = 56;
            this.lv_Message.UseCompatibleStateImageBehavior = false;
            this.lv_Message.View = System.Windows.Forms.View.List;
            this.lv_Message.SelectedIndexChanged += new System.EventHandler(this.lv_Message_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "List Account";
            // 
            // lv_ListAccount
            // 
            this.lv_ListAccount.HideSelection = false;
            this.lv_ListAccount.Location = new System.Drawing.Point(620, 94);
            this.lv_ListAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_ListAccount.Name = "lv_ListAccount";
            this.lv_ListAccount.Size = new System.Drawing.Size(220, 298);
            this.lv_ListAccount.TabIndex = 53;
            this.lv_ListAccount.UseCompatibleStateImageBehavior = false;
            this.lv_ListAccount.View = System.Windows.Forms.View.List;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconnect.Location = new System.Drawing.Point(13, 419);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(143, 39);
            this.btn_Disconnect.TabIndex = 51;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.Location = new System.Drawing.Point(204, 419);
            this.btn_Listen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(137, 39);
            this.btn_Listen.TabIndex = 50;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Port";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(79, 25);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(199, 22);
            this.txt_Port.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Message";
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Location = new System.Drawing.Point(376, 92);
            this.pb_Avatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(236, 300);
            this.pb_Avatar.TabIndex = 43;
            this.pb_Avatar.TabStop = false;
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 488);
            this.Controls.Add(this.lv_Message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_ListAccount);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Avatar);
            this.Name = "Bai04";
            this.Text = "Bai04";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_ListAccount;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Avatar;
    }
}