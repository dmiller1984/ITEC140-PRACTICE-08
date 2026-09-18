namespace NameAndBirthday;
partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblFN = new Label();
        textBox1 = new TextBox();
        lblLN = new Label();
        dtpBD = new Label();
        textBox2 = new TextBox();
        dateTimePicker1 = new DateTimePicker();
        btnDisplay = new Button();
        btnClear = new Button();
        btnExit = new Button();
        lblResult = new Label();
        SuspendLayout();
        // 
        // lblFN
        // 
        lblFN.AutoSize = true;
        lblFN.Location = new Point(12, 35);
        lblFN.Name = "lblFN";
        lblFN.Size = new Size(67, 15);
        lblFN.TabIndex = 0;
        lblFN.Text = "First Name:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(76, 32);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 1;
        // 
        // lblLN
        // 
        lblLN.AutoSize = true;
        lblLN.Location = new Point(182, 38);
        lblLN.Name = "lblLN";
        lblLN.Size = new Size(66, 15);
        lblLN.TabIndex = 2;
        lblLN.Text = "Last Name:";
        // 
        // dtpBD
        // 
        dtpBD.AutoSize = true;
        dtpBD.Location = new Point(373, 38);
        dtpBD.Name = "dtpBD";
        dtpBD.Size = new Size(62, 15);
        dtpBD.TabIndex = 3;
        dtpBD.Text = "Birth Date:";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(254, 35);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(113, 23);
        textBox2.TabIndex = 4;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Format = DateTimePickerFormat.Short;
        dateTimePicker1.Location = new Point(441, 33);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(95, 23);
        dateTimePicker1.TabIndex = 5;
        // 
        // btnDisplay
        // 
        btnDisplay.Location = new Point(12, 73);
        btnDisplay.Name = "btnDisplay";
        btnDisplay.Size = new Size(75, 23);
        btnDisplay.TabIndex = 7;
        btnDisplay.Text = "Display:";
        btnDisplay.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(461, 150);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 23);
        btnClear.TabIndex = 8;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(461, 179);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(75, 23);
        btnExit.TabIndex = 9;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        // 
        // lblResult
        // 
        lblResult.Location = new Point(93, 77);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(460, 70);
        lblResult.TabIndex = 10;
        lblResult.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(583, 212);
        Controls.Add(lblResult);
        Controls.Add(btnExit);
        Controls.Add(btnClear);
        Controls.Add(btnDisplay);
        Controls.Add(dateTimePicker1);
        Controls.Add(textBox2);
        Controls.Add(dtpBD);
        Controls.Add(lblLN);
        Controls.Add(textBox1);
        Controls.Add(lblFN);
        Name = "Form1";
        Text = "Name and Date practice form";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblFN;
    private TextBox textBox1;
    private Label lblLN;
    private Label dtpBD;
    private TextBox textBox2;
    private DateTimePicker dateTimePicker1;
    private Button btnDisplay;
    private Button btnClear;
    private Button btnExit;
    private Label lblResult;
}
