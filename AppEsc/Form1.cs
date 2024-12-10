namespace AppEsc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text.Trim().Equals("") || passwordTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("you must enter the user and password", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (userTextBox.Text.Trim().Equals("Admin") && passwordTextBox.Text.Trim().Equals("1234"))
                {
                    Form2 form2 = new Form2();
                    Tools.openNewForm(this, form2);
                }
                else
                {
                    MessageBox.Show("User or password incorrects", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
