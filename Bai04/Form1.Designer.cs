namespace Bai04;

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
        textBoxDateOfBirth = new TextBox();
        label4 = new Label();
        buttonCheckZodiac = new Button();
        labelResult = new Label();
        label2 = new Label();
        button1 = new Button();
        textBox1 = new TextBox();
        label3 = new Label();
        button2 = new Button();
        label5 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 49);
        label1.Name = "label1";
        label1.Size = new Size(177, 19);
        label1.TabIndex = 0;
        label1.Text = "Nhập Ngày Tháng Năm ";
        // 
        // textBoxDateOfBirth
        // 
        textBoxDateOfBirth.Location = new Point(195, 41);
        textBoxDateOfBirth.Multiline = true;
        textBoxDateOfBirth.Name = "textBoxDateOfBirth";
        textBoxDateOfBirth.Size = new Size(333, 35);
        textBoxDateOfBirth.TabIndex = 1;
        // 
        // label4
        // 
        label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(210, 119);
        label4.Name = "label4";
        label4.Size = new Size(214, 34);
        label4.TabIndex = 7;
        label4.Text = "BẠN THUỘC CUNG ";
        // 
        // buttonCheckZodiac
        // 
        buttonCheckZodiac.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonCheckZodiac.Location = new Point(504, 96);
        buttonCheckZodiac.Name = "buttonCheckZodiac";
        buttonCheckZodiac.Size = new Size(151, 44);
        buttonCheckZodiac.TabIndex = 9;
        buttonCheckZodiac.Text = "KIỂM TRA ";
        buttonCheckZodiac.UseVisualStyleBackColor = true;
        // 
        // labelResult
        // 
        labelResult.BackColor = Color.AntiqueWhite;
        labelResult.ForeColor = Color.LightGray;
        labelResult.Location = new Point(185, 171);
        labelResult.Name = "labelResult";
        labelResult.Size = new Size(289, 48);
        labelResult.TabIndex = 10;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(12, 51);
        label2.Name = "label2";
        label2.Size = new Size(210, 23);
        label2.TabIndex = 1;
        label2.Text = "Nhập Ngày Tháng Năm ";
        // 
        // button1
        // 
        button1.BackColor = SystemColors.AppWorkspace;
        button1.Location = new Point(502, 45);
        button1.Name = "button1";
        button1.Size = new Size(104, 52);
        button1.TabIndex = 3;
        button1.Text = "KIỂM TRA ";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(228, 45);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(245, 52);
        textBox1.TabIndex = 4;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label3
        // 
        label3.BackColor = SystemColors.ControlLight;
        label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(228, 159);
        label3.Name = "label3";
        label3.Size = new Size(245, 48);
        label3.TabIndex = 5;
        label3.Click += label3_Click;
        // 
        // button2
        // 
        button2.BackColor = SystemColors.AppWorkspace;
        button2.Location = new Point(502, 155);
        button2.Name = "button2";
        button2.Size = new Size(104, 52);
        button2.TabIndex = 6;
        button2.Text = "Thoát";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label5.Location = new Point(12, 175);
        label5.Name = "label5";
        label5.Size = new Size(175, 20);
        label5.TabIndex = 7;
        label5.Text = "BẠN THUỘC CUNG";
        // 
        // Form1
        // 
        BackColor = Color.LightSteelBlue;
        ClientSize = new Size(630, 315);
        Controls.Add(label5);
        Controls.Add(button2);
        Controls.Add(label3);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(label2);
        Name = "Form1";
        Text = "Cung Hoàng Đạo ";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxDateOfBirth;
    private Label label4;
    private Button buttonCheckZodiac;
    private Label labelResult;
    private Label label2;
    private Button button1;
    private TextBox textBox1;
    private Label label3;
    private Button button2;
    private Label label5;
}
