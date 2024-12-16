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
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
            foreach (var user in User.users)
            {
                checkedListBoxCollaborators.Items.Add(user.userName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            if (projectNameTextBox.Text.Equals("") || checkedListBoxCollaborators.CheckedItems.Count == 0 || descriptionTextBox.Text.Equals("") || taskNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please complete all the fields.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                String projectName = projectNameTextBox.Text;
                bool projectExists = Project.projects.Exists(p => String.Equals(p.name, projectName, StringComparison.OrdinalIgnoreCase));
                if (projectExists)
                {
                    MessageBox.Show("The project already exists", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    Project p = new Project();
                    Task t = new Task();

                    p.name = projectNameTextBox.Text;
                    p.description = descriptionTextBox.Text;
                    p.startDate = startDateProject.Value;
                    p.endDate = endDateProject.Value;
                    p.changeState(Project.ProjectState.toDo);

                    t.taskname = taskNameTextBox.Text.Trim();
                    t.startDate = startDateTask.Value;
                    t.endDate = endDateTask.Value;
                    t.changeTaskState(Task.TaskState.toDo);

                    foreach (String collaboratorName in checkedListBoxCollaborators.CheckedItems)
                    {
                        User selectedUser = User.users.Find(user => user.userName == collaboratorName);

                        t.collaborators.Add(selectedUser);
                    }

                    p.tasks.Add(t);
                    Project.projects.Add(p);

                    MessageBox.Show("Project added", "Succes!", MessageBoxButtons.OK);

                    projectNameTextBox.Clear();
                    descriptionTextBox.Clear();
                    taskNameTextBox.Clear();
                    foreach (int index in checkedListBoxCollaborators.CheckedIndices)
                    {
                        checkedListBoxCollaborators.SetItemChecked(index, false);
                    }

                    Tools.writeJsonProjects();
                }
            }
        }

        private void checkedListBoxCollaborators_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Tools.openNewForm(this, f2);
        }
    }
}
