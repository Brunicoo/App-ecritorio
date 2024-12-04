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
                //verificar si el usuario esta en el array y si la contrasel a
                if (userTextBox.Text.Trim().Equals("Admin") && passwordTextBox.Text.Trim().Equals("1234"))
                {
                    Form2 form2 = new Form2();
                    form2.StartPosition = FormStartPosition.CenterParent;

                    form2.Show();
                    this.Hide();
                    
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

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
