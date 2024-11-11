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
            if (userTextBox.Text.Equals("") || passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("you must enter the user and password", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (userTextBox.Text.Equals("Admin") && passwordTextBox.Text.Equals("1234"))
                {
                    Form2 form2 = new Form2();
                    form2.StartPosition = FormStartPosition.CenterParent;

                    this.Hide();
                    form2.Show();
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
