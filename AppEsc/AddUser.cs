using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEsc
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Tools.openNewForm(this, f2);
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {

            if (newUserTextBox.Text.Equals("") || newPasswordTextBox.Text.Equals(""))
            {
                MessageBox.Show("you must enter the user and password", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                String name = newUserTextBox.Text.Trim();
                String password = newPasswordTextBox.Text.Trim();

                bool userExists = User.users.Exists(user => string.Equals(user.userName, name, StringComparison.OrdinalIgnoreCase));

                if (userExists)
                {
                    MessageBox.Show("This user exists", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    User user = new User(name, password);
                    User.users.Add(user);
                    MessageBox.Show("User added", "Succes!", MessageBoxButtons.OK);

                    Form2 f2 = new Form2();
                    Tools.openNewForm(this, f2);
                }


            }
        }
    }
}
