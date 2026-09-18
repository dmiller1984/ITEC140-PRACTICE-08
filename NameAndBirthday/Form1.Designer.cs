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
        txtFN = new TextBox();
        lblLN = new Label();
        dtpBD = new Label();
        txtLN = new TextBox();
        dtp = new DateTimePicker();
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
        // txtFN
        // 
        txtFN.Location = new Point(76, 32);
        txtFN.Name = "txtFN";
        txtFN.Size = new Size(100, 23);
        txtFN.TabIndex = 1;
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
        // txtLN
        // 
        txtLN.Location = new Point(254, 35);
        txtLN.Name = "txtLN";
        txtLN.Size = new Size(113, 23);
        txtLN.TabIndex = 4;
        // 
        // dtp
        // 
        dtp.Format = DateTimePickerFormat.Short;
        dtp.Location = new Point(441, 33);
        dtp.Name = "dtp";
        dtp.Size = new Size(95, 23);
        dtp.TabIndex = 5;
        // 
        // btnDisplay
        // 
        btnDisplay.Location = new Point(12, 73);
        btnDisplay.Name = "btnDisplay";
        btnDisplay.Size = new Size(75, 23);
        btnDisplay.TabIndex = 7;
        btnDisplay.Text = "Display:";
        btnDisplay.UseVisualStyleBackColor = true;
        btnDisplay.Click += btnDisplay_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(461, 150);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 23);
        btnClear.TabIndex = 8;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(461, 179);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(75, 23);
        btnExit.TabIndex = 9;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // lblResult
        // 
        lblResult.Location = new Point(93, 77);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(460, 70);
        lblResult.TabIndex = 10;
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
        Controls.Add(dtp);
        Controls.Add(txtLN);
        Controls.Add(dtpBD);
        Controls.Add(lblLN);
        Controls.Add(txtFN);
        Controls.Add(lblFN);
        Name = "Form1";
        Text = "Name and Date practice form";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblFN;
    private TextBox txtFN;
    private Label lblLN;
    private Label dtpBD;
    private TextBox txtLN;
    private DateTimePicker dtp;
    private Button btnDisplay;
    private Button btnClear;
    private Button btnExit;
    private Label lblResult;
}
