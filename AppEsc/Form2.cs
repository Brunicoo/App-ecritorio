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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddUsersButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            Tools.openNewForm(this, addUser);
        }

        private void AddProjectsButton_Click(object sender, EventArgs e)
        {

            if (User.users.Count <= 0)
            {
                MessageBox.Show("Create users before create a project", "Warning", MessageBoxButtons.OK);

            }
            else
            {
                CreateProject createProject = new CreateProject();
                Tools.openNewForm(this, createProject);
            }
        }

        private void viewUsersButton_Click(object sender, EventArgs e)
        {
            EditProjectscs editProjectscs = new EditProjectscs();
            Tools.openNewForm(this, editProjectscs);
        }
    }
}
