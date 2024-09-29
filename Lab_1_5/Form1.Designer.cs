namespace Lab_1_5
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.comboxGender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGendercol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtResult1col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResult2col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResult3col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAveragecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRankcol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(584, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Result 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(584, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Result 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(584, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Result 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gender: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name: ";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt3.Location = new System.Drawing.Point(682, 205);
            this.txt3.Margin = new System.Windows.Forms.Padding(5);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(122, 30);
            this.txt3.TabIndex = 16;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt2.Location = new System.Drawing.Point(682, 126);
            this.txt2.Margin = new System.Windows.Forms.Padding(5);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(122, 30);
            this.txt2.TabIndex = 15;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt1.Location = new System.Drawing.Point(682, 47);
            this.txt1.Margin = new System.Windows.Forms.Padding(5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 30);
            this.txt1.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(99, 50);
            this.txtname.Margin = new System.Windows.Forms.Padding(5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(424, 30);
            this.txtname.TabIndex = 12;
            // 
            // comboxGender
            // 
            this.comboxGender.FormattingEnabled = true;
            this.comboxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboxGender.Location = new System.Drawing.Point(99, 123);
            this.comboxGender.Name = "comboxGender";
            this.comboxGender.Size = new System.Drawing.Size(213, 37);
            this.comboxGender.TabIndex = 24;
            this.comboxGender.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboxGender);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 284);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a candidate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIDcol,
            this.txtnamecol,
            this.txtGendercol,
            this.txtResult1col,
            this.txtResult2col,
            this.txtResult3col,
            this.txtAveragecol,
            this.txtRankcol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 106);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "List of candidates:";
            // 
            // txtIDcol
            // 
            this.txtIDcol.HeaderText = "ID";
            this.txtIDcol.MinimumWidth = 6;
            this.txtIDcol.Name = "txtIDcol";
            this.txtIDcol.Width = 125;
            // 
            // txtnamecol
            // 
            this.txtnamecol.HeaderText = "Name";
            this.txtnamecol.MinimumWidth = 6;
            this.txtnamecol.Name = "txtnamecol";
            this.txtnamecol.Width = 125;
            // 
            // txtGendercol
            // 
            this.txtGendercol.HeaderText = "Gender";
            this.txtGendercol.MinimumWidth = 6;
            this.txtGendercol.Name = "txtGendercol";
            this.txtGendercol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtGendercol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txtGendercol.Width = 125;
            // 
            // txtResult1col
            // 
            this.txtResult1col.HeaderText = "Result 1";
            this.txtResult1col.MinimumWidth = 6;
            this.txtResult1col.Name = "txtResult1col";
            this.txtResult1col.Width = 125;
            // 
            // txtResult2col
            // 
            this.txtResult2col.HeaderText = "Result 2";
            this.txtResult2col.MinimumWidth = 6;
            this.txtResult2col.Name = "txtResult2col";
            this.txtResult2col.Width = 125;
            // 
            // txtResult3col
            // 
            this.txtResult3col.HeaderText = "Result 3";
            this.txtResult3col.MinimumWidth = 6;
            this.txtResult3col.Name = "txtResult3col";
            this.txtResult3col.Width = 125;
            // 
            // txtAveragecol
            // 
            this.txtAveragecol.HeaderText = "Average";
            this.txtAveragecol.MinimumWidth = 6;
            this.txtAveragecol.Name = "txtAveragecol";
            this.txtAveragecol.Width = 125;
            // 
            // txtRankcol
            // 
            this.txtRankcol.HeaderText = "Ranking";
            this.txtRankcol.MinimumWidth = 6;
            this.txtRankcol.Name = "txtRankcol";
            this.txtRankcol.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 481);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox comboxGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnamecol;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtGendercol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtResult1col;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtResult2col;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtResult3col;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAveragecol;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtRankcol;
    }
}

