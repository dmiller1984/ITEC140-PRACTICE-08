namespace NameAndBirthday;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnDisplay_Click(object sender, EventArgs e)
    {
        lblResult.Text = txtFN.Text +" "+ txtLN.Text +" " + dtp.Text;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        lblResult.Text = "";
        txtFN.Text = "";
        txtLN.Text = "";
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
